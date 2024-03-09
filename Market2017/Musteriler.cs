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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        
        void guncelle()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Update MUSTERI set AdiSoyadi=@AdiSoyadi,Telefonu=@Telefonu,Adresi=@Adresi,Bakiye=@Bakiye where MusteriID=@MusteriID";

            cmd.Parameters.Add("@AdiSoyadi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Telefonu", SqlDbType.VarChar, 16);
            cmd.Parameters.Add("@Adresi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Bakiye", SqlDbType.Float);
            cmd.Parameters.Add("@MusteriID", SqlDbType.Int);


            cmd.Parameters["@AdiSoyadi"].Value = textBox2.Text.ToUpper();
            cmd.Parameters["@Telefonu"].Value = textBox3.Text.ToUpper();
            cmd.Parameters["@Adresi"].Value = textBox4.Text.ToUpper();
            cmd.Parameters["@Bakiye"].Value = textBox5.Text.ToUpper();
            cmd.Parameters["@MusteriID"].Value = Convert.ToInt32(textBox1.Text);




            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int sonuc = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            if (sonuc == 1)
            {
                MessageBox.Show("İşlem Başarılı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                verileriGetir();
            }

            else
            {
                MessageBox.Show("İşlem Yapılamadı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
        DataTable dt = new DataTable();
        void AdSoyadicin()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * from MUSTERI where AdiSoyadi like  '%'+@AdiSoyadi+'%'";

            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;

            cmd.Parameters.Add("@AdiSoyadi", SqlDbType.VarChar, 50);
            cmd.Parameters["@AdiSoyadi"].Value = textBox6.Text;

            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void aktar()
        {
            if (dataGridView1.CurrentRow == null)
                return;

            textBox2.Text = dataGridView1.CurrentRow.Cells["AdiSoyadi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Telefonu"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Adresi"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Bakiye"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["MusteriID"].Value.ToString();
        }
        void sil(int id)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "delete from MUSTERI where MusteriID=@ID";

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = id;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();


            int a = cmd.ExecuteNonQuery(); // siqül sorgusu çalıştırılıyor
            if (a == 1)
            {
                MessageBox.Show("İşlem Gerçekleştirildi", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verileriGetir();
            }
            else
            {
                MessageBox.Show("İşlem Yapılamadı", "Program", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        void verileriGetir()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select*from MUSTERI";

            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;

            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void kaydet()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into MUSTERI(AdiSoyadi,Telefonu,Adresi,Bakiye)values(@AdiSoyadi,@Telefonu,@Adresi,@Bakiye)";

            cmd.Parameters.Add("@AdiSoyadi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Telefonu", SqlDbType.VarChar, 16);
            cmd.Parameters.Add("@Adresi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Bakiye", SqlDbType.Float);


            cmd.Parameters["@AdiSoyadi"].Value = textBox2.Text.ToUpper();
            cmd.Parameters["@Telefonu"].Value = textBox3.Text.ToUpper();
            cmd.Parameters["@Adresi"].Value = textBox4.Text.ToUpper();
            cmd.Parameters["@Bakiye"].Value = textBox5.Text.ToUpper();




            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int sonuc = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            if (sonuc == 1)
            {
                MessageBox.Show("İşlem Başarılı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                verileriGetir();
            }

            else
            {
                MessageBox.Show("İşlem Yapılamadı.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MusteriID"].Value);

            DialogResult cevap = MessageBox.Show(this, "Bu Kaydı Silmek İstediğinize Eminmisiniz ?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (cevap == DialogResult.Yes)
            {
                sil(id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            verileriGetir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aktar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdSoyadicin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.dt = dt;  //Veriler rapor görüntüleme formuna aktarılmalıdır.
            f.Show();
        }
    }
}
