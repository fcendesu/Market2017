using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market2017
{
    public partial class Birimler : Form
    {
        public Birimler()
        {
            InitializeComponent();
        }

        void verileriGetir()
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

            dataGridView1.DataSource = dt;
            label3.Text = "Toplam Kayıt=" + dt.Rows.Count.ToString();

        }

        void kaydet()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into BIRIM(BirimAdi)values(@BirimAdi)";
            cmd.Parameters.Add("@BirimAdi", SqlDbType.VarChar, 10);
            cmd.Parameters["@BirimAdi"].Value = textBox1.Text.ToUpper();

            
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

        void sil(int BirimID)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"server=(LOCAL)\SQLSERVER2016;Database=MARKET2017;Trusted_Connection=True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from BIRIM where BirimID=@ID";

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = BirimID;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery(); //Sql sorgusu çalıştırılıyor
            if (a == 1)
            {
                MessageBox.Show("İşleminiz Gerçekleştirildi.", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verileriGetir();
            }
            else
            {
                MessageBox.Show("İşleminiz Yapılamadı.", "Program", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }


        private void Birimler_Load(object sender, EventArgs e)
        {
            verileriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()=="")
            {
                MessageBox.Show("Birim Alanı Boş Olamaz.", Settings.programAdi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            kaydet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BirimID"].Value);

            DialogResult cevap = MessageBox.Show(this, "Bu Kaydı Silmek İstediğinize Emin misiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (cevap == DialogResult.Yes)
            {
                sil(id);
            }
        }
    }
}
