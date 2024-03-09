using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Settings.programAdi;
        }

        private void birimlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Birimler f = new Birimler();
            f.ShowDialog();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteriler f = new Musteriler();
            f.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler f = new Urunler();
            f.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void burdanÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void bideBurdanÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void kasaHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kasa_Listesi f = new Kasa_Listesi();
            f.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            YeniKasa f = new YeniKasa();
            f.ShowDialog();

        }

        private void yeniKasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniKasa f = new YeniKasa();
            f.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            YeniSatis f = new YeniSatis();
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SatisListesi f = new SatisListesi();
            f.Show();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
