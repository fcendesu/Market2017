using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Market2017
{
    public partial class Kasa_Listesi : Form
    {
        public Kasa_Listesi()
        {
            InitializeComponent();
        }
        DataTable dtKasa = new DataTable();
       
        void sil(int id)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from KASA where KasaID=@KasaID";

            cmd.Parameters.Add("@KasaID", SqlDbType.Int);
            cmd.Parameters["@KasaID"].Value = id;


            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int sonuc = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            if (sonuc == 1)
            {
                MessageBox.Show("İşlem Başarılı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                verileriGetirHepsi();
            }

            else
            {
                MessageBox.Show("İşlem Yapılamadı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         void hesapla()
        {
            decimal toplamTahsilat = 0, toplamOdeme = 0, tutar = 0;
            bool tipTahsilat;
            for(int i=0;i<dtKasa.Rows.Count; i++)
            {
                tutar = Convert.ToDecimal(dtKasa.Rows[i]["Tutar"].ToString());
                tipTahsilat = Convert.ToBoolean(dtKasa.Rows[i]["TipTahsilat"]);

                if (tipTahsilat)
                    toplamTahsilat += tutar;
                else
                    toplamOdeme += tutar;
            }

            labelTahsilat.Text = "TAHSİLAT : " + toplamTahsilat.ToString("N2");
            labelOdeme.Text = "ÖDEME : " + toplamOdeme.ToString("N2");
        }
        
        
        void verileriGetirHepsi()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select K.*,M.AdiSoyadi,(CASE when TipTahsilat = 1 Then 'TAHSİLAT' when TipTahsilat = 0 Then 'ÖDEME' END) as Tip from KASA as K inner join MUSTERI as M on K.Musteri = M.MusteriID order by Tarih";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            
            da.Fill(dtKasa);

            dataGridView1.DataSource = dtKasa;
            label3.Text = "Toplam Kayıt=" + dtKasa.Rows.Count.ToString();

            hesapla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verileriGetirHepsi();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YeniKasa f = new YeniKasa();
            f. ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            YeniKasa f = new YeniKasa();
            f.labelMusteriAdi.Text = dataGridView1.CurrentRow.Cells["AdiSoyadi"].Value.ToString();
            f.labelMusteriID.Text = dataGridView1.CurrentRow.Cells["Musteri"].Value.ToString();
            f.labelKasaID.Text = dataGridView1.CurrentRow.Cells["KasaID"].Value.ToString();
            f.textBox1.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
            f.textBox2.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            f.comboBox1.SelectedIndex = Convert.ToInt32(Convert.ToBoolean(dataGridView1.CurrentRow.Cells["TipTahsilat"].Value.ToString()));
            f.dateTimePicker1.Value =Convert.ToDateTime( dataGridView1.CurrentRow.Cells["Tarih"].Value);

            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id=Convert.ToInt32 (dataGridView1.CurrentRow.Cells["KasaID"].Value.ToString());
            sil(id);
            
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            KasaListesiRaporu kls = new KasaListesiRaporu();
            kls.dt = dtKasa;
            kls.ShowDialog();
        }
    }
}
