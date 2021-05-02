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
    public partial class frmWorkScheduleReport : Form
    {
        public frmWorkScheduleReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "ReportDayWork.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            string startTime = dtpStart.Value.ToShortDateString();
            string endTime = dtpEnd.Value.ToShortDateString();
            rds.Value = DAO.StaffDAO.Instance.getWorkDayStaffList(startTime, endTime);
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void frmWorkScheduleReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
