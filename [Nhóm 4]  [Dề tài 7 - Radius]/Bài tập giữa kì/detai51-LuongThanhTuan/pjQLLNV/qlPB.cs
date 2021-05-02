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
    public partial class qlPB : Form
    {
        Model1 db = new Model1();
        int vt = -1;
        public qlPB()
        {
            InitializeComponent();
        }
        private void LoadNV()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
            con.Open();
            con.Close();
            string sql = "SELECT * FROM PHONGBAN";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql,con);
            dap.Fill(ds);
            dgvPB.DataSource = ds.Tables[0];
            dgvPB.Refresh();
        }
        private void SetTextEmpty()
        {
            txtMa.Clear();
            txtTen.Clear();
  
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            lbMess.Text= "";
            try
            {
                var NV = db.PHONGBANs.Where(p => p.MAPB == txtMa.Text).FirstOrDefault();
                if (txtMa.Text == "" || txtTen.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                if (NV != null)
                    lbMess.Text = "Phòng ban đã tồn tại";
                PHONGBAN nv = new PHONGBAN();
                nv.MAPB = txtMa.Text.Trim();
                nv.TENPB = txtTen.Text.Trim();

                db.PHONGBANs.Add(nv);
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void qlPB_Load(object sender, EventArgs e)
        {
            LoadNV();
            SetTextEmpty();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lbMess.Text = " ";
            try
            {
                if (txtMa.Text == "" || txtTen.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                PHONGBAN sv = db.PHONGBANs.Where(p => p.MAPB == txtMa.Text).FirstOrDefault();
                sv.MAPB = txtMa.Text.Trim();
                sv.TENPB = txtTen.Text.Trim();

                db.Entry(sv).State = EntityState.Modified;
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dgvPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt >= 0 && vt < dgvPB.Rows.Count)
            {
                txtMa.Text = dgvPB.Rows[vt].Cells["MAPB"].Value.ToString();
                txtTen.Text = dgvPB.Rows[vt].Cells["TENPB"].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            if (vt >= 0 && vt < dgvPB.Rows.Count)
            {
                lbMess.Text = "";
                var NV = db.PHONGBANs.Where(p => p.MAPB == txtMa.Text).FirstOrDefault();
                PHONGBAN nv = db.PHONGBANs.Where(p => p.MAPB == txtMa.Text).FirstOrDefault();
                db.PHONGBANs.Remove(nv);
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
                vt = -1;

            }
            else
            {
                lbMess.Text = "Chưa chọn nhân viên";

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
