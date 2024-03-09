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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }
        public SatisListesi satisListesi;
        public YeniKasa yeniKasa;
        public YeniSatis yeniSatis;
        public int form = -1;

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

                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
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

            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            verileriGetir();
        }

        private void MusteriListesi_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow==null)
                return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MusteriID"].Value);

            string ad = dataGridView1.CurrentRow.Cells["AdiSoyadi"].Value.ToString();

            if (form == 1) //YeniKasa Formu
            {
                yeniKasa.labelMusteriID.Text = id.ToString();
                yeniKasa.labelMusteriAdi.Text = ad;

            }
            else if (form == 2)//Yeni Satış Formu
            {
                yeniSatis.labelMusteriID.Text = id.ToString();
                yeniSatis.labelMusteriAdi.Text = ad;
            }
            else if(form==3)//Satış Listesi
            {
                satisListesi.labelMusteriAdi.Text = ad;
                satisListesi.labelMusteriID.Text = id.ToString();
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdSoyadicin();
        }
    }
}
