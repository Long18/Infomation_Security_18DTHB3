using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.Xpf.Core.ConditionalFormatting;

namespace Phan_mem_ngan_hang
{
    public partial class btn_Themkhachhang : DevExpress.XtraEditors.XtraForm
    {
        public btn_Themkhachhang()
        {
            InitializeComponent();
        }

        private void BindGrid(List<KHACHHANG> listkhachhang)
        {
            dgvKhachhang.Rows.Clear();
            foreach (var item in listkhachhang)
            {
                int a = dgvKhachhang.Rows.Add();
                dgvKhachhang.Rows[a].Cells[0].Value = item.MAKH;
                dgvKhachhang.Rows[a].Cells[1].Value = item.HOTEN;
                dgvKhachhang.Rows[a].Cells[2].Value = item.NGAYSINH;
                dgvKhachhang.Rows[a].Cells[3].Value = item.GIOITINH;
                dgvKhachhang.Rows[a].Cells[4].Value = item.SOCMND;
                dgvKhachhang.Rows[a].Cells[5].Value = item.DIACHI;
                dgvKhachhang.Rows[a].Cells[6].Value = item.HOKHAU;
                dgvKhachhang.Rows[a].Cells[7].Value = item.SDT;
            }
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        private void loadData()
        {

            DBcontext context = new DBcontext();
            List<KHACHHANG> listkhachhang = context.KHACHHANGs.ToList();
            BindGrid(listkhachhang);

        }
        private void btn_Themkhachhang_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdb_nam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            try
            {
                if (txtMakh.Text.Trim() == "" || txtHoten.Text.Trim() == "" || txtCMND.Text.Trim() == "" || txtDC.Text.Trim() == "" || txtHKTT.Text.Trim() == "" || txtSDT.Text.Trim() == "")
                {

                    throw new Exception("Vui lòng nhập thông tin đầy đủ");
                }
                    string ngay = string.Format(dtpNgaysinh.Value.Date.ToString());
                    KHACHHANG kh = new KHACHHANG();
                    kh.MAKH = txtMakh.Text;
                    kh.HOTEN = txtHoten.Text;
                    kh.NGAYSINH = dtpNgaysinh.Value.Date;
                    kh.GIOITINH = gioitinh;
                    kh.SOCMND = txtCMND.Text;
                    kh.DIACHI = txtDC.Text;
                    kh.HOKHAU = txtHKTT.Text;
                    kh.SDT = txtSDT.Text;
                    DBcontext context = new DBcontext();
                    KHACHHANG finDB = context.KHACHHANGs.FirstOrDefault(p => p.MAKH == kh.MAKH);
                    if (finDB == null)
                    {
                        context.KHACHHANGs.Add(kh);
                        context.SaveChanges();
                    }
                    loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vua moi thêm "+ "Thông tin khách hàng: "+txtHoten.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }

        private void bntThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}