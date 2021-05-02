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
    public partial class FormTinhL : Form
    {

        Model1 db = new Model1();

        int vt = -1;

        public FormTinhL()
        {
            InitializeComponent();
        }
        private void LoadNV()
        {
            var lstTL = db.CHITIETBANGLUONGs
                .Join(db.DMTinhluongs,
                    ct => ct.MASP,
                    tl => tl.MASP,
                    (ct, tl) => new
                    {
                        //ctID = ct.m
                        THANG = ct.THANG,
                        MANV = ct.MANV,
                        MASP = ct.MASP,
                        SLSP = ct.SLSP,
                        DONGIA = tl.DONGIA,

                    }
                )
                .Join(db.NHANVIENs,
                    ct => ct.MANV,
                    nv => nv.MANV,
                    (ct, nv) => new
                    {
                        THANG = ct.THANG,
                        MANV = ct.MANV,
                        TENNV = nv.TENNV,
                        MASP = ct.MASP,
                        SLSP = ct.SLSP,
                        DONGIA = ct.DONGIA,
                        MUCLUONG = nv.MUCLUONG

                    }
                )
                .ToList();
            dgvTL.DataSource = lstTL;
            dgvTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


        }

        private void fillCBB()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";

            string sql = " SELECT * FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sMANV = myreader.GetString(0);
                    cbbThemMANV.Items.Add(sMANV);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

            lbMess.Text = " ";
            try
            {
                if (txtSLSP.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                CHITIETBANGLUONG sv = db.CHITIETBANGLUONGs.Where(p => p.MANV == txtMaNV.Text).FirstOrDefault();
                sv.THANG = txtThang.Text.Trim();
                sv.MANV = txtMaNV.Text.Trim();
                sv.MASP = txtMaSP.Text.Trim();
                sv.SLSP = txtSLSP.Text.Trim();

                db.Entry(sv).State = EntityState.Modified;
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
                lbMess.Text = "Sửa thành công ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void SetTextEmpty()
        {
            txtThang.Clear();
            txtMaNV.Clear();
            txtDG.Clear();
            txtMaSP.Clear();
            txtSLSP.Clear();
        }
        private void FormTinhL_Load(object sender, EventArgs e)
        {

            LoadNV();
            fillCBB();
        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMess.Text = "";

            vt = e.RowIndex;
            if (vt >= 0 && vt < dgvTL.Rows.Count)
            {
                txtThang.Text = dgvTL.Rows[vt].Cells["THANG"].Value.ToString();
                txtMaNV.Text = dgvTL.Rows[vt].Cells["MANV"].Value.ToString();
                txtMaSP.Text = dgvTL.Rows[vt].Cells["MASP"].Value.ToString();
                txtSLSP.Text = dgvTL.Rows[vt].Cells["SLSP"].Value.ToString();
                txtDG.Text = dgvTL.Rows[vt].Cells["DONGIA"].Value.ToString();
                txtMucL.Text = dgvTL.Rows[vt].Cells["MUCLUONG"].Value.ToString();
                txtThuong.Text = "0";
                txtTL.Text = "0";
                txtThemT.Text = dgvTL.Rows[vt].Cells["THANG"].Value.ToString();
                cbbThemMANV.Text = dgvTL.Rows[vt].Cells["MANV"].Value.ToString();
                txtThemMasp.Text = dgvTL.Rows[vt].Cells["MASP"].Value.ToString();
                txtThemSLSP.Text = dgvTL.Rows[vt].Cells["SLSP"].Value.ToString();


            }
        }

        private void btnTinhL_Click(object sender, EventArgs e)
        {

            lbMess.Text = " ";
            NHANVIEN nvc = new NHANVIEN();
            float slsp = float.Parse(txtSLSP.Text);
            float dg = float.Parse(txtDG.Text);
            float ml = float.Parse(txtMucL.Text);
            float th = float.Parse(txtThuong.Text);


            txtTL.Text = ((slsp * dg) + ml + th).ToString();

            try
            {
                if (txtSLSP.Text == "")
                    lbMess.Text = "Chưa nhập SLSP";
                BANGLUONG nv = db.BANGLUONGs.Where(p => p.MANV == txtMaNV.Text).FirstOrDefault();
                nv.TONGTIENLUONG = txtTL.Text.Trim();


                db.Entry(nv).State = EntityState.Modified;
                db.SaveChanges();
                LoadNV();
                lbMess.Text = "Lưu lại thành công";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtThemT.Text == "" || cbbThemMANV.Text == "" || txtThemMasp.Text == "" || txtThemSLSP.Text == "")
                    lbMess2.Text = "Nhập chưa đủ thông tin";

               BANGLUONG nv = new BANGLUONG();
                nv.THANG = txtThemT.Text.Trim();
                nv.MANV = cbbThemMANV.Text.Trim();
                nv.TONGTIENLUONG = txtTL.Text.Trim();

                CHITIETBANGLUONG bv = new CHITIETBANGLUONG();
                bv.THANG = txtThemT.Text.Trim();
                bv.MANV = cbbThemMANV.Text.Trim();
                bv.MASP = txtThemMasp.Text.Trim();
                bv.SLSP = txtThemSLSP.Text.Trim();
                db.BANGLUONGs.Add(nv);
                db.CHITIETBANGLUONGs.Add(bv);
                db.SaveChanges();
                   LoadNV();
                   SetTextEmpty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt >= 0 && vt < dgvTL.Rows.Count)
            {
                CHITIETBANGLUONG nv = db.CHITIETBANGLUONGs.Where(p => p.THANG == txtThemT.Text).FirstOrDefault();
                BANGLUONG bl = db.BANGLUONGs.Where(c => c.THANG == txtThemT.Text).FirstOrDefault();
                db.CHITIETBANGLUONGs.Remove(nv);
                db.SaveChanges();
                db.BANGLUONGs.Remove(bl);
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
                vt = -1;
            }
            else
            {
                MessageBox.Show("Chọn nhân viên!", "Thông báo");
            }
        }
    }
}