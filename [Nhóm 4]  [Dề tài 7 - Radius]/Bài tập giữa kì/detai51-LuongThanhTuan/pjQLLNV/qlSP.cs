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
    public partial class qlSP : Form
    {
        Model1 db = new Model1();
        int vt = -1;
        public qlSP()
        {
            InitializeComponent();
        }

        private void LoadNV()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
            con.Open();
            con.Close();
            string sql = "SELECT * FROM DMTinhluong";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
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
            lbMess.Text = "";
            try
            {
                var NV = db.DMTinhluongs.Where(p => p.MASP == txtMa.Text).FirstOrDefault();
                if (txtMa.Text == "" || txtTen.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                if (NV != null)
                    lbMess.Text = "Sản phẩm đã tồn tại";
                DMTinhluong nv = new DMTinhluong();
                nv.MASP = txtMa.Text.Trim();
                nv.DONGIA = txtTen.Text.Trim();

                db.DMTinhluongs.Add(nv);
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            lbMess.Text = " ";
            try
            {
                if (txtMa.Text == "" || txtTen.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                DMTinhluong sv = db.DMTinhluongs.Where(p => p.MASP == txtMa.Text).FirstOrDefault();
                sv.MASP = txtMa.Text.Trim();
                sv.DONGIA = txtTen.Text.Trim();

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
                txtMa.Text = dgvPB.Rows[vt].Cells["MASP"].Value.ToString();
                txtTen.Text = dgvPB.Rows[vt].Cells["DONGIA"].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


            if (vt >= 0 && vt < dgvPB.Rows.Count)
            {
                lbMess.Text = "";
                var NV = db.DMTinhluongs.Where(p => p.MASP == txtMa.Text).FirstOrDefault();
                DMTinhluong nv = db.DMTinhluongs.Where(p => p.MASP == txtMa.Text).FirstOrDefault();
                db.DMTinhluongs.Remove(nv);
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
                vt = -1;

            }
            else
            {
                lbMess.Text = "Chưa chọn sản phẩm";

            }
        }

        private void qlSP_Load(object sender, EventArgs e)
        {
            LoadNV();
            SetTextEmpty();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
