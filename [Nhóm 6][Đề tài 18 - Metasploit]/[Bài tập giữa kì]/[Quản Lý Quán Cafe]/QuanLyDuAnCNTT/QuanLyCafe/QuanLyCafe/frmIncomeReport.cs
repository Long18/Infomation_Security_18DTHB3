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
    public partial class frmIncomeReport : Form
    {
        public frmIncomeReport()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "ReportIncome.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            string startTime = dtpStart.Value.ToShortDateString();
            string endTime = dtpEnd.Value.ToShortDateString();
            rds.Value = DAO.DrinkDAO.Instance.getSoldDinksList(startTime, endTime);
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
