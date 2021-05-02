using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyCafe
{
    public partial class frmBillReport : Form
    {
        string idBill;
        public frmBillReport(string idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "ReportBill.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = DAO.BillDAO.Instance.getDinksBillList(this.idBill);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
