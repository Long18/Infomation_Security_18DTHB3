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
using System.Data.Entity;

namespace lancuoi
{
    public partial class quanlinhanvien : Form
    {
        Model1 db = new Model1();
        public quanlinhanvien()
        {
            InitializeComponent();
        }

        private void quanlinhanvien_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lbtime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
            LoadNV();
        }
        private void LoadNV()
        {
            /* SqlConnection con = new SqlConnection();
             con.ConnectionString = @"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
             con.Open();
             con.Close();
             string sql = "SELECT * FROM LICHSU";
             DataSet ds = new DataSet();
             SqlDataAdapter dap = new SqlDataAdapter(sql, con);
             dap.Fill(ds);
             dgvqlnv.DataSource = ds.Tables[0];
             dgvqlnv.Refresh();*/
            var nghia = db.LICHSUs.ToList();
            dgvqlnv.DataSource = nghia;
            dgvqlnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void lbtime_Click(object sender, EventArgs e)
        {

        }

        private void dgvqlnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
