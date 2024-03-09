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
    public partial class YeniSatis : Form
    {
        public YeniSatis()
        {
            InitializeComponent();
        }
        DataTable dtSatis;
        void temizle()
        {
            tabloOlustur();
            labelTutar.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Select();
            textBox2.Text = "1";
        }
        void tutarBul()
        {
            decimal tutar = 0, toplamtutar = 0;
            for (int i = 0; i < dtSatis.Rows.Count; i++)
            {
                tutar = Convert.ToDecimal(dtSatis.Rows[i]["Tutar"].ToString());
                toplamtutar += tutar;
            }
            labelTutar.Text = toplamtutar.ToString("N2");
        }
        public void urunEkle()
        {
            string barkod, tanimi, birimAdi;
            decimal miktar, birimFiyat, tutar;

            barkod = textBox1.Text.Trim();
            miktar = Convert.ToDecimal(textBox2.Text);

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select U.*,B.BirimAdi from URUN as U inner join BIRIM as B on U.Birimi=B.BirimID where U.Barkodu=@Barkod";
            cmd.Parameters.AddWithValue("@Barkod", barkod);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(this, "Ürün Bulunamadı", "Program", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            tanimi = dt.Rows[0]["Tanimi"].ToString();
            birimAdi = dt.Rows[0]["BirimAdi"].ToString();
            birimFiyat = Convert.ToDecimal(dt.Rows[0]["Fiyati"].ToString());
            tutar = miktar * birimFiyat;

            DataRow dr = null;
            dr=dtSatis.NewRow();
            dr["Barkodu"] = barkod;
            dr["Tanimi"] = tanimi;
            dr["BirimAdi"] = birimAdi;
            dr["Miktar"] = miktar;
            dr["BirimFiyat"] = birimFiyat;
            dr["Tutar"] = tutar;
            dtSatis.Rows.Add(dr);
            dataGridView1.DataSource = dtSatis;
            tutarBul();

            textBox1.Text = "";
            textBox2.Text = "1";
        }
        void tabloOlustur()
        {
            
            dtSatis = new DataTable();
            dtSatis.Columns.Add("Barkodu", Type.GetType("System.String"));
            dtSatis.Columns.Add("Tanimi", Type.GetType("System.String"));
            dtSatis.Columns.Add("BirimAdi", Type.GetType("System.String"));
            dtSatis.Columns.Add("Miktar", Type.GetType("System.Decimal"));
            dtSatis.Columns.Add("BirimFiyat", Type.GetType("System.Decimal"));
            dtSatis.Columns.Add("Tutar", Type.GetType("System.Decimal"));
            dataGridView1.DataSource = dtSatis;
        }
        private void YeniSatis_Load(object sender, EventArgs e)
        {
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriListesi liste = new MusteriListesi();
            liste.yeniSatis = this;
            liste.form = 2;
            liste.ShowDialog();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int kod = (int)e.KeyChar;
            if (kod == 13)
                urunEkle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            dtSatis.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            tutarBul();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(labelMusteriID.Text=="")
            {
                MessageBox.Show(this, "Satış Yapılacak Müşteriyi Seçiniz", "Program", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if(dtSatis.Rows.Count==0)
            {
                MessageBox.Show(this, "Satış Yok", "Program", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            DateTime tarih = dateTimePicker1.Value;
            int musteriID = Convert.ToInt32(labelMusteriID.Text);
            string aciklama = textBox3.Text.ToUpper();
            decimal fisTutari = Convert.ToDecimal(labelTutar.Text);
            int satisNo = getirSatisNo();

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlTransaction tr = cnn.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.Transaction = tr;

                cmd.CommandText = "Insert into SATIS(Musterisi,Tarih,Tutar,Aciklama,SatisID)values(@Musterisi,@Tarih,@Tutar,@Aciklama,@SatisID)";
                cmd.Parameters.Add("@Musterisi", SqlDbType.Int);
                cmd.Parameters.Add("@Tarih", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@Tutar", SqlDbType.Decimal);
                cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar,250);
                cmd.Parameters.Add("@SatisID", SqlDbType.Int);

                cmd.Parameters["@Musterisi"].Value = musteriID;
                cmd.Parameters["@Tarih"].Value = tarih;
                cmd.Parameters["@Tutar"].Value = fisTutari;
                cmd.Parameters["@Aciklama"].Value = aciklama;
                cmd.Parameters["@SatisID"].Value = satisNo;

                int a = cmd.ExecuteNonQuery();
                if(a<1)
                {
                    tr.Rollback();

                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    return;
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "Insert into SATISDETAY(SatisID,Barkodu,BirimFiyat,Miktar,Tutar)values(@SatisID,@Barkodu,@BirimFiyat,@Miktar,@Tutar)";
                cmd.Parameters.Add("@SatisID", SqlDbType.Int);
                cmd.Parameters.Add("@Barkodu", SqlDbType.VarChar,13);
                cmd.Parameters.Add("@BirimFiyat", SqlDbType.Decimal);
                cmd.Parameters.Add("@Miktar", SqlDbType.Decimal);
                cmd.Parameters.Add("@Tutar", SqlDbType.Decimal);

                for (int i = 0; i < dtSatis.Rows.Count; i++)
                {
                    cmd.Parameters["@SatisID"].Value = satisNo;
                    cmd.Parameters["@Barkodu"].Value = dtSatis.Rows[i]["Barkodu"];
                    cmd.Parameters["@Miktar"].Value = dtSatis.Rows[i]["Miktar"];
                    cmd.Parameters["@BirimFiyat"].Value = dtSatis.Rows[i]["BirimFiyat"];
                    cmd.Parameters["@Tutar"].Value = dtSatis.Rows[i]["Tutar"];

                    a = cmd.ExecuteNonQuery();
                    if (a < 1)
                    {
                        tr.Rollback();

                        if (cnn.State == ConnectionState.Open)
                            cnn.Close();
                        return;
                    }
                }

                tr.Commit();
                MessageBox.Show("İşlem Gerçekleştirildi.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            catch(Exception ex)
            {
                tr.Rollback();
                MessageBox.Show(this, "İşlemde Hata Var\n\n"+ex.Message, "Program", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

        }
        int getirSatisNo()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select ISNULL(MAX(satisID),0) from SATIS";


            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int sonuc = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return sonuc+1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunListesi liste = new UrunListesi();
            liste.yeniSatis = this;
            liste.form = 1;
            liste.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
