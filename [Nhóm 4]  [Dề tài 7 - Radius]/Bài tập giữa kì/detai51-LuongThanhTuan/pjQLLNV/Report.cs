using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using pjQLLNV;
using Microsoft.Reporting.WinForms;
namespace pjQLLNV
{
    public partial class Report : Form
    {
        Model1 db = new Model1();

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
                      var lstTL = db.BANGLUONGs
                 .Join(db.NHANVIENs,
                     bl => bl.MANV,
                     nv => nv.MANV,
                     (bl, nv) => new 
                     {
                     
                        THANG = bl.THANG,
                         MANV = nv.MANV,
                         TENNV = nv.TENNV,
                         TONGTIENLUONG = bl.TONGTIENLUONG,
                     }
                 )

                 .ToList();
            this.reportViewer1.LocalReport.ReportPath = "RptBangluong.rdlc";
            var dataresourc = new ReportDataSource("BLDataSet",lstTL);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataresourc);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void ClsBangluongBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
