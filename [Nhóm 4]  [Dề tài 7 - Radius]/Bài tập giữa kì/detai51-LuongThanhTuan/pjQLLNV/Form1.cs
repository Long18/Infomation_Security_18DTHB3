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
    public partial class Form1 : Form
    {
        
        Model1 db = new Model1();
        int vt = -1;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadNV()
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
            dgvNV.DataSource = lstNV;
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
 
        private void SetTextEmpty()
        {
            txtMANV.Clear();
            txtTenNV.Clear();
            txtMucL.Clear();
            cbbBacL.Text = "";
            cbbMaPB.Text = "";
            cbbPhai.Text = "";           
            txtDiachi.Clear();
            txtDT.Clear();
            txtTrinhDo.Clear();
            txtGhiChu.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var NV = db.NHANVIENs.Where(p => p.MANV == txtMANV.Text).FirstOrDefault();
                if (txtMANV.Text == "" || txtTenNV.Text == "" || txtMucL.Text == "" || cbbBacL.Text == ""
                    || cbbMaPB.Text == "" || cbbPhai.Text == "" || dtNS.Text == "" || txtDiachi.Text == ""
                    || txtDT.Text == "" || txtTrinhDo.Text == ""||txtGhiChu.Text == "")
                    throw new Exception("Nhập chưa đủ thông tin");
                if (NV != null)
                    throw new Exception("Nhân viên đã tồn tại");
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = txtMANV.Text.Trim();
                nv.TENNV = txtTenNV.Text.Trim();
                nv.MUCLUONG = txtMucL.Text.Trim();
                nv.BACLUONG = cbbBacL.Text.Trim();
                nv.MAPB = cbbMaPB.Text.Trim();
                nv.PHAI = cbbPhai.Text.Trim();
                nv.NGAYSINH = dtNS.Value;
                nv.DIACHI = txtDiachi.Text.Trim();
                nv.DIENTHOAI = txtDT.Text.Trim();
                nv.TRINHDOCM = txtTrinhDo.Text.Trim();
                nv.GHICHU = txtGhiChu.Text.Trim();
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();


                string tk = lbTK.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

                string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOAN");
                table = ds.Tables["TAIKHOAN"];
                if (table.Rows.Count != 0)
                {
                    btnThem.Text = "Thêm nhân viên mới";

                    DateTime time = DateTime.Now;
                    lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                    LICHSU na = new LICHSU();
                    na.TAIKHOAN = lbTK.Text.Trim();
                    na.THOIGIAN = lbTG.Text.Trim();
                    na.THAOTAC = btnThem.Text.Trim();
                    db.LICHSUs.Add(na);
                    db.SaveChanges();
                    lbTG.Text = "";
                    btnThem.Text = "Thêm";
                }

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
                if (txtMANV.Text == "" || txtTenNV.Text == "" || txtMucL.Text == "" || cbbBacL.Text == ""
                    || cbbMaPB.Text == "" || cbbPhai.Text == "" || dtNS.Text == "" || txtDiachi.Text == ""
                    || txtDT.Text == "" || txtTrinhDo.Text == "" || txtGhiChu.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                NHANVIEN nv = db.NHANVIENs.Where(p => p.MANV == txtMANV.Text).FirstOrDefault();
                nv.MANV = txtMANV.Text.Trim();
                nv.TENNV = txtTenNV.Text.Trim();
                nv.MUCLUONG = txtMucL.Text.Trim();
                nv.BACLUONG = cbbBacL.Text.Trim();
                nv.MAPB = cbbMaPB.Text.Trim();
                nv.PHAI = cbbPhai.Text.Trim();
                nv.NGAYSINH = dtNS.Value;
                nv.DIACHI = txtDiachi.Text.Trim();
                nv.DIENTHOAI = txtDT.Text.Trim();
                nv.TRINHDOCM = txtTrinhDo.Text.Trim();
                nv.GHICHU = txtGhiChu.Text.Trim();

                db.Entry(nv).State = EntityState.Modified;
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();


                string tk = lbTK.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

                string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOAN");
                table = ds.Tables["TAIKHOAN"];
                if (table.Rows.Count != 0)
                {
                    btnSua.Text = "Sửa thông tin NV";

                    DateTime time = DateTime.Now;
                    lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                    LICHSU na = new LICHSU();
                    na.TAIKHOAN = lbTK.Text.Trim();
                    na.THOIGIAN = lbTG.Text.Trim();
                    na.THAOTAC = btnSua.Text.Trim();
                    db.LICHSUs.Add(na);
                    db.SaveChanges();
                    lbTG.Text = "";
                    btnSua.Text = "Sửa";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt >= 0 && vt < dgvNV.Rows.Count)
            {
                NHANVIEN nv = db.NHANVIENs.Where(p => p.MANV == txtMANV.Text).FirstOrDefault();
                db.NHANVIENs.Remove(nv);
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
                vt = -1;

                string tk = lbTK.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

                string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOAN");
                table = ds.Tables["TAIKHOAN"];
                if (table.Rows.Count != 0)
                {
                    btnXoa.Text = "Xóa một nhân viên";

                    DateTime time = DateTime.Now;
                    lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                    LICHSU na = new LICHSU();
                    na.TAIKHOAN = lbTK.Text.Trim();
                    na.THOIGIAN = lbTG.Text.Trim();
                    na.THAOTAC = btnXoa.Text.Trim();
                    db.LICHSUs.Add(na);
                    db.SaveChanges();
                    lbTG.Text = "";
                    btnXoa.Text = "Sửa";
                }


            }
            else
            {
                MessageBox.Show("Chọn nhân viên!", "Thông báo");
            }
        }
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt >= 0 && vt < dgvNV.Rows.Count)
            {
                txtMANV.Text = dgvNV.Rows[vt].Cells["MANV"].Value.ToString();
                txtTenNV.Text = dgvNV.Rows[vt].Cells["TENNV"].Value.ToString();
                txtMucL.Text = dgvNV.Rows[vt].Cells["MUCLUONG"].Value.ToString();
                cbbBacL.Text = dgvNV.Rows[vt].Cells["BACLUONG"].Value.ToString();
                cbbMaPB.Text = dgvNV.Rows[vt].Cells["MAPB"].Value.ToString();

                cbbPhai.Text = dgvNV.Rows[vt].Cells["PHAI"].Value.ToString();
                dtNS.Text = dgvNV.Rows[vt].Cells["NGAYSINH"].Value.ToString();
                txtDiachi.Text = dgvNV.Rows[vt].Cells["DIACHI"].Value.ToString();
                txtDT.Text = dgvNV.Rows[vt].Cells["DIENTHOAI"].Value.ToString();
                txtTrinhDo.Text = dgvNV.Rows[vt].Cells["TRINHDOCM"].Value.ToString();
                txtGhiChu.Text = dgvNV.Rows[vt].Cells["GHICHU"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNV();      
            SetTextEmpty();
            lbTK.Text = temp3;
        }
        public string temp3;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
