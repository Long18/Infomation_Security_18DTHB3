using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;


namespace pjQLLNV
{
    public partial class ReportLichsu : Form
    {
        Model1 db = new Model1();
        public ReportLichsu()
        {
            InitializeComponent();
        }

        private void ReportLichsu_Load(object sender, EventArgs e)
        {

            loadNV();




        }

        private void loadNV()
        {
            var data = db.LICHSUs.ToList();
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var dataresourc = new ReportDataSource("DataSet1", data);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataresourc);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void lbXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "DELETE FROM LICHSU";
            SqlDataReader data = com.ExecuteReader();
            con.Close();

            loadNV();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
