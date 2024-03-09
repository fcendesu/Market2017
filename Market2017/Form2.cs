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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public DataTable dt;
        public decimal tutar = 0;
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 rapor = new CrystalReport1();  //Düzenlediğimiz Rapor Nesnesi
            rapor.SetDataSource(dt); //Raporun veri kaynağı ayarlandı
            rapor.SetParameterValue("ToplamBakiye",600);
            crystalReportViewer1.ReportSource = rapor;  //Görüntülenecek rapor ayarlandı
        }
    }
}
