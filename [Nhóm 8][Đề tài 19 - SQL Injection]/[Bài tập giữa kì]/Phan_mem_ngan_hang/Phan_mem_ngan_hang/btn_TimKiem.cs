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

namespace Phan_mem_ngan_hang
{
    public partial class btn_TimKiem : DevExpress.XtraEditors.XtraForm
    {
        public btn_TimKiem()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Load(object sender, EventArgs e)
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

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vừa mới:" + btnThoat.Text+","+"chức năng tìm kiếm";
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
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
        private void loadData()
        {

            DBcontext context = new DBcontext();
            List<KHACHHANG> listkhachhang = context.KHACHHANGs.ToList();
            BindGrid(listkhachhang);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBcontext context = new DBcontext();
                KHACHHANG delete = context.KHACHHANGs.FirstOrDefault(p => p.MAKH == txtMakh.Text);
                if (delete == null)
                {
                    throw new Exception("Không tìm thấy dữ liệu để xóa");
                }
                DialogResult dig = MessageBox.Show("Bạn có chắc là muốn xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dig == DialogResult.Yes)
                {
                    context.KHACHHANGs.Remove(delete);
                    context.SaveChanges();
                    BindGrid(context.KHACHHANGs.ToList());
                }
                loadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vua moi:" + btn_Xoa.Text+","+"khách hàng"+txtHoten.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            try
            {
                string searchValue = txtMakh.Text;

                dgvKhachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                foreach (DataGridViewRow row in dgvKhachhang.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vua moi:" + btnTimKiem.Text+","+"khách hàng: "+txtHoten.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            string gioitinh;
            if (rdb_nam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            kh.MAKH = txtMakh.Text;
            kh.HOTEN = txtHoten.Text;
            kh.NGAYSINH = dtpNgaysinh.Value;
            kh.GIOITINH = gioitinh;
            kh.SOCMND = txtCMND.Text;
            kh.DIACHI = txtDC.Text;
            kh.HOKHAU = txtHKTT.Text;
            kh.SDT = txtSDT.Text;

            DBcontext context = new DBcontext();
            KHACHHANG dbUpdate = context.KHACHHANGs.FirstOrDefault(p => p.MAKH == kh.MAKH);
            if (dbUpdate != null)
            {
                dbUpdate.MAKH = kh.MAKH;
                dbUpdate.HOTEN = kh.HOTEN;
                dbUpdate.NGAYSINH = kh.NGAYSINH;
                dbUpdate.GIOITINH = kh.GIOITINH;
                dbUpdate.DIACHI = kh.DIACHI;
                dbUpdate.HOKHAU = kh.HOKHAU;
                dbUpdate.SDT = kh.SDT;//.... 
                context.SaveChanges(); //lưu thay đổi
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
            loadData();
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vua moi:" + button1.Text+","+"khách hàng: "+txtHoten.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ngay = String.Format("(MM/DD/YYYY)", dtpNgaysinh.Value);
                string makh = dgvKhachhang.SelectedRows[0].Cells[0].Value + "";
                DBcontext context = new DBcontext();
                KHACHHANG dgv = context.KHACHHANGs.FirstOrDefault(p => p.MAKH == makh);
                if (dgv != null)
                {
                    txtMakh.Text = dgv.MAKH;
                    txtHoten.Text = dgv.HOTEN;
                    dtpNgaysinh.Text = dgv.NGAYSINH.ToString();
                    txtCMND.Text = dgv.SOCMND;
                    txtDC.Text = dgv.DIACHI;
                    txtHKTT.Text = dgv.HOKHAU;
                    txtSDT.Text = dgv.SDT;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhấp vào ô bên trái ngoài cùng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}