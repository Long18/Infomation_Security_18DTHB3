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
    
    public partial class ReportDsNV : Form
    {
        Model1 db = new Model1();

        public ReportDsNV()
        {
            InitializeComponent();
        }

        private void ReportDsNV_Load(object sender, EventArgs e)
        {
                        var lstNV = db.NHANVIENs
                .Join(
                    db.PHONGBANs,
                    nv => nv.MAPB,
                    pb => pb.MAPB,

                    (nv, pb) => new
                    {
                        MANV = nv.MANV,
                        TENNV = nv.TENNV,
                        MUCLUONG = nv.MUCLUONG,
                        BACLUONG = nv.BACLUONG,
                        MAPB = nv.MAPB,
                        TENPB = pb.TENPB,
                        PHAI = nv.PHAI,
                        NGAYSINH = nv.NGAYSINH,
                        DIACHI = nv.DIACHI,
                        DIENTHOAI = nv.DIENTHOAI,
                        TRINHDOCM = nv.TRINHDOCM,
                        GHICHU = nv.GHICHU,
                    }
                )
                .ToList();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = "RptDsNV.rdlc";
            var dataresourc = new ReportDataSource("DataSetDsNV", lstNV);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataresourc);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
