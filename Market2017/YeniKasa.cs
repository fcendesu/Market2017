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
    public partial class YeniKasa : Form
    {
        public YeniKasa()
        {
            InitializeComponent();
            temizle();
        }
        void guncelle()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "UPDATE KASA set Tarih=@Tarih,Musteri=@Musteri,Tutar=@Tutar,TipTahsilat=@TipTahsilat,Aciklama=@Aciklama where KasaID=@KasaID";


            cmd.Parameters.Add("@Tarih", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@Musteri", SqlDbType.Int);
            cmd.Parameters.Add("@Tutar", SqlDbType.Decimal);
            cmd.Parameters.Add("@TipTahsilat", SqlDbType.Bit);
            cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar, 250);
            cmd.Parameters.Add("@KasaID", SqlDbType.Int);

            cmd.Parameters["@Tarih"].Value = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            cmd.Parameters["@Musteri"].Value = Convert.ToInt32(labelMusteriID.Text);
            cmd.Parameters["@Tutar"].Value = Convert.ToDecimal(textBox1.Text);
            cmd.Parameters["@TipTahsilat"].Value = Convert.ToBoolean(comboBox1.SelectedIndex);
            cmd.Parameters["@Aciklama"].Value = textBox2.Text.ToUpper();
            cmd.Parameters["@KasaID"].Value = Convert.ToInt32(labelKasaID.Text);


            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int sonuc = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            if (sonuc == 1)
            {
                MessageBox.Show("İşlem Başarılı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                temizle();
            }

            else
            {
                MessageBox.Show("İşlem Yapılamadı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void kaydet()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into KASA(Tarih,Musteri,Tutar,TipTahsilat,Aciklama)values(@Tarih,@Musteri,@Tutar,@TipTahsilat,@Aciklama)";


            cmd.Parameters.Add("@Tarih", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@Musteri", SqlDbType.Int);
            cmd.Parameters.Add("@Tutar", SqlDbType.Decimal);
            cmd.Parameters.Add("@TipTahsilat", SqlDbType.Bit);
            cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar, 250);

            cmd.Parameters["@Tarih"].Value = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            cmd.Parameters["@Musteri"].Value = Convert.ToInt32(labelMusteriID.Text);
            cmd.Parameters["@Tutar"].Value = Convert.ToDecimal(textBox1.Text);
            cmd.Parameters["@TipTahsilat"].Value = Convert.ToBoolean(comboBox1.SelectedIndex); 
            cmd.Parameters["@Aciklama"].Value = textBox2.Text.ToUpper();


            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int sonuc = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            if (sonuc == 1)
            {
                MessageBox.Show("İşlem Başarılı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                temizle();
            }

            else
            {
                MessageBox.Show("İşlem Yapılamadı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void temizle()
        {
            labelKasaID.Text = "";
            labelMusteriAdi.Text = "";
            labelMusteriID.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MusteriListesi f = new MusteriListesi();
            f.form = 1;
            f.yeniKasa = this;
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelMusteriAdi.Text== ""|| textBox1.Text.Trim()=="")
            {
                MessageBox.Show("Sonunda '*' Bulunan Alanları Boş Bırakmayınız !", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (labelKasaID.Text == "")
                kaydet();
            else
                guncelle();
        }
    }
}
