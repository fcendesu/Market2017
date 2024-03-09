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
    public partial class KasaListesiRaporu : Form
    {
        public KasaListesiRaporu()
        {
            InitializeComponent();
        }
        public DataTable dt;
        public decimal tutar = 0;
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(dt);
            rapor.SetParameterValue("ToplamBakiye", 600);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
