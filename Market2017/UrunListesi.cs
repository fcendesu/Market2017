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
    public partial class UrunListesi : Form
    {
        public UrunListesi()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
            textBox4.Text = "";
        }
        public YeniSatis yeniSatis;
        public int form;
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            urunleriDoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
                urunleriDoldurBarkod();
            else if (comboBox2.SelectedIndex == 1)
                urunleriDoldurTanimi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            string barkod = dataGridView1.CurrentRow.Cells["Barkodu"].Value.ToString();
            if(form==1)
            {
                yeniSatis.textBox1.Text = barkod;
                yeniSatis.urunEkle();
            }
            this.Close();
        }
    }
}
