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
using System.Data.SqlClient;

namespace pjQLLNV
{
    public partial class Timkiem : Form
    {
        Model1 db = new Model1();
      
  
        public Timkiem()
        {
            InitializeComponent();
        }
        private void LoadNV()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
            con.Open();
            con.Close();
            string sql = " SELECT * FROM NHANVIEN";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvNV.DataSource = ds.Tables[0];
            dgvNV.Refresh();
        }
        public void loadKey()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
            con.Open();
            con.Close();
            if(cbbChon.Text =="Mã NV")
            {
                string sql = " SELECT * FROM NHANVIEN WHERE MANV LIKE '%" + txttim.Text + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvNV.DataSource = ds.Tables[0];
                dgvNV.Refresh();
            }
            if (cbbChon.Text == "Tên NV")
            {
                string sql = " SELECT * FROM NHANVIEN WHERE TENNV LIKE '%" + txttim.Text + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvNV.DataSource = ds.Tables[0];
                dgvNV.Refresh();
            }
            if (cbbChon.Text == "Mã PB")
            {
                string sql = " SELECT * FROM NHANVIEN WHERE MAPB LIKE '%" + txttim.Text + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvNV.DataSource = ds.Tables[0];
                dgvNV.Refresh();
            }

        }
        private void Timkiem_Load(object sender, EventArgs e)
        {
           LoadNV();
            cbbChon.Text = "Mã NV";
            lbTK.Text = temp4;






        }
        public string temp4;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;
        private void button1_Click(object sender, EventArgs e)
        {
            loadKey();


            string tk = lbTK.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

            string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "TAIKHOAN");
            table = ds.Tables["TAIKHOAN"];
            if (table.Rows.Count != 0)
            {
                button1.Text = "Tìm kiếm nhân viên";

                DateTime time = DateTime.Now;
                lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                LICHSU na = new LICHSU();
                na.TAIKHOAN = lbTK.Text.Trim();
                na.THOIGIAN = lbTG.Text.Trim();
                na.THAOTAC = button1.Text.Trim();
                db.LICHSUs.Add(na);
                db.SaveChanges();
                lbTG.Text = "";
                button1.Text = "";
            }
        }

        private void txtMANV_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
