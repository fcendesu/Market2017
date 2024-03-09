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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
        }
        void guncelle()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Update URUN set Barkodu=@Barkodu,Tanimi=@Tanimi,Birimi=@Birimi,Fiyati=@Fiyati where Barkodu=@sart";

            cmd.Parameters.Add("@Barkodu", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Tanimi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Birimi", SqlDbType.Int);
            cmd.Parameters.Add("@Fiyati", SqlDbType.Float);
            cmd.Parameters.Add("@Sart", SqlDbType.VarChar, 16);

            cmd.Parameters["@Barkodu"].Value = textBox1.Text.ToUpper();
            cmd.Parameters["@Tanimi"].Value = textBox2.Text.ToUpper();
            cmd.Parameters["@Birimi"].Value = Convert.ToInt32(comboBox1.SelectedValue);
            cmd.Parameters["@Fiyati"].Value = Convert.ToDecimal(textBox3.Text);
            cmd.Parameters["@Sart"].Value = labelID.Text;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int sonuc = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            if (sonuc == 1)
            {
                MessageBox.Show("İşlem Başarılı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                birimleriDoldur();
            }

            else
            {
                MessageBox.Show("İşlem Yapılamadı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
        
    }
        void sil(string barkod)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"server=(LOCAL)\SQLSERVER2016;Database=MARKET2017;Trusted_Connection=True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from URUN where Barkodu=@Barkod";
            cmd.Parameters.Add("@Barkod", SqlDbType.VarChar);

           
            cmd.Parameters["@barkod"].Value =barkod ;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery(); //Sql sorgusu çalıştırılıyor
            if (a == 1)
            {
                MessageBox.Show("İşleminiz Gerçekleştirildi.", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                urunleriDoldur();
            }
            else
            {
                MessageBox.Show("İşleminiz Yapılamadı.", "Program", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        void urunleriDoldur()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select U.*,B.BirimAdi from URUN as U inner join BIRIM as B on U.Birimi=B.BirimID order by Barkodu ";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label5.Text = "Toplam Ürün Sayısı=" + dt.Rows.Count.ToString();

        }
            void urunleriDoldurTanimi()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select U.*,B.BirimAdi from URUN as U inner join BIRIM as B on U.Birimi=B.BirimID where Tanimi like '%'+@Parametre+'%' order by Barkodu";
            cmd.Parameters.AddWithValue("@Parametre", textBox4.Text);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            label5.Text = "Toplam Ürün Sayısı=" + dt.Rows.Count.ToString();
        }
        void urunleriDoldurBarkod()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select U.*,B.BirimAdi from URUN as U inner join BIRIM as B on U.Birimi=B.BirimID where Barkodu like '%'+@Parametre+'%' order by Barkodu";
            cmd.Parameters.AddWithValue("@Parametre", textBox4.Text);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            label5.Text = "Toplam Ürün Sayısı=" + dt.Rows.Count.ToString();
        }
        void aktar()
        {
            if (dataGridView1.CurrentRow == null)
                return;
            labelID.Text = dataGridView1.CurrentRow.Cells["Barkodu"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["Barkodu"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Tanimi"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["BirimAdi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Fiyati"].Value.ToString();
        }
        void kaydet()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into URUN(Barkodu,Tanimi,Birimi,Fiyati)values(@Barkodu,@Tanimi,@Birimi,@Fiyati)";

            cmd.Parameters.Add("@Barkodu", SqlDbType.VarChar, 13);
            cmd.Parameters.Add("@Tanimi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Birimi", SqlDbType.Int);
            cmd.Parameters.Add("@Fiyati", SqlDbType.Float);

            cmd.Parameters["@Barkodu"].Value = textBox1.Text.ToUpper();
            cmd.Parameters["@Tanimi"].Value = textBox2.Text.ToUpper();
            cmd.Parameters["@Birimi"].Value = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            cmd.Parameters["@Fiyati"].Value = textBox3.Text.ToUpper();

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int sonuc = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            if (sonuc == 1)
            {
                MessageBox.Show("İşlem Başarılı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                birimleriDoldur();
            }

            else
            {
                MessageBox.Show("İşlem Yapılamadı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temizle();
            urunleriDoldur();
        }
        void birimleriDoldur()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select*from BIRIM order by BirimAdi";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "BirimAdi";
            comboBox1.ValueMember = "BirimID";

        }
        void temizle()
        {
            labelID.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            urunleriDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aktar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            string barkod = dataGridView1.CurrentRow.Cells["Barkodu"].Value.ToString();

            DialogResult cevap = MessageBox.Show(this, "Bu Kaydı Silmek İstediğinize Emin misiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (cevap == DialogResult.Yes)
            {
                sil(barkod);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
                urunleriDoldurBarkod();
            else if (comboBox2.SelectedIndex == 1)
                urunleriDoldurTanimi();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            birimleriDoldur();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            guncelle();
        }
    }
}
