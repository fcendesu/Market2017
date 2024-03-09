using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market2017
{
    public partial class SatisListesi : Form
    {
        public SatisListesi()
        {
            InitializeComponent();
        }
       
        void sil(int id)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from SATIS  where SatisID=@SatisID";

            cmd.Parameters.Add("@SatisID", SqlDbType.Int);
            cmd.Parameters["@SatisID"].Value = id;


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
            decimal toplamTutar=0, tutar = 0;
            for (int i = 0; i < dtSatis.Rows.Count; i++)
            {
                tutar = Convert.ToDecimal(dtSatis.Rows[i]["Tutar"].ToString());
                toplamTutar += tutar;
            }

            labelTutar.Text = "TOPLAM : " + toplamTutar.ToString("N2");
        }

        DataTable dtSatis = new DataTable();
        void verileriGetirHepsi()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select S.*,M.AdiSoyadi from SATIS as S inner join MUSTERI as M on S.Musterisi=M.MusteriID order by Tarih";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            dtSatis = new DataTable();
            da.Fill(dtSatis);

            dataGridView1.DataSource = dtSatis;
            label3.Text = "Toplam Kayıt=" + dtSatis.Rows.Count.ToString();

            hesapla();

        }

        void verileriGetirTarih()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select S.*,M.AdiSoyadi from SATIS as S inner join MUSTERI as M on S.Musterisi=M.MusteriID where Tarih Between @Tarih1 and @Tarih2 order by Tarih";

            DateTime tarih2= Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            tarih2 = tarih2.AddDays(1);
            cmd.Parameters.Add("@Tarih1", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@Tarih2", SqlDbType.SmallDateTime);

            cmd.Parameters["@Tarih1"].Value = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            cmd.Parameters["@Tarih2"].Value = tarih2;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            dtSatis = new DataTable();
            da.Fill(dtSatis);

            dataGridView1.DataSource = dtSatis;
            label3.Text = "Toplam Kayıt=" + dtSatis.Rows.Count.ToString();

            hesapla();

        }
        void verileriGetirMusteri()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select S.*,M.AdiSoyadi from SATIS as S inner join MUSTERI as M on S.Musterisi=M.MusteriID where Tarih Between @Tarih1 and @Tarih2 and Musterisi=@Musterisi order by Tarih";

            DateTime tarih2 = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            tarih2 = tarih2.AddDays(1);
            cmd.Parameters.Add("@Tarih1", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@Tarih2", SqlDbType.SmallDateTime);

            cmd.Parameters["@Tarih1"].Value = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            cmd.Parameters["@Tarih2"].Value = tarih2;

            cmd.Parameters.Add("@Musterisi", SqlDbType.Int);
            cmd.Parameters["@Musterisi"].Value =labelMusteriID.Text;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            dtSatis = new DataTable();
            da.Fill(dtSatis);

            dataGridView1.DataSource = dtSatis;
            label3.Text = "Toplam Kayıt=" + dtSatis.Rows.Count.ToString();

            hesapla();

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verileriGetirHepsi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SatisID"].Value.ToString());
            sil(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
                verileriGetirMusteri();
            else
                 verileriGetirTarih();
        }

        private void SatisListesi_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button4.Enabled = true;
                labelMusteriAdi.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
                labelMusteriAdi.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriListesi liste = new MusteriListesi();
            liste.satisListesi = this;
            liste.form = 3;
            liste.ShowDialog();
        }
    }
}
