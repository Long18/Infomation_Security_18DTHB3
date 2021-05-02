using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Phan_mem_ngan_hang
{
    public partial class btn_timkiemNhanvien : DevExpress.XtraEditors.XtraForm
    {
        public btn_timkiemNhanvien()
        {
            InitializeComponent();
        }
        private void BindGrid(List<NHANVIEN> listNhanvien)
        {
            dgvNhanvien.Rows.Clear();
            foreach (var item in listNhanvien)
            {
                int a = dgvNhanvien.Rows.Add();
                dgvNhanvien.Rows[a].Cells[0].Value = item.MANV;
                dgvNhanvien.Rows[a].Cells[1].Value = item.HOTENNV;
                dgvNhanvien.Rows[a].Cells[2].Value = item.NGAYSINH;
                dgvNhanvien.Rows[a].Cells[3].Value = item.GIOITINH;
                dgvNhanvien.Rows[a].Cells[4].Value = item.PHONGBAN.TENPB;
                dgvNhanvien.Rows[a].Cells[5].Value = item.CHUCVU;
                dgvNhanvien.Rows[a].Cells[6].Value = item.LUONGCB;
                dgvNhanvien.Rows[a].Cells[7].Value = item.CHINHANH.TENCHINHANH;
            }
        }
        
        private void btn_timkiemNhanvien_Load(object sender, EventArgs e)
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
        private void PhongbanchinhanhCombobox(List<PHONGBAN> listphongban, List<CHINHANH> listchinhanh)
        {
            this.cboCHINHANH.DataSource = listchinhanh;
            this.cboCHINHANH.DisplayMember = "TENCHINHANH";
            this.cboCHINHANH.ValueMember = "MACHINHANH";
            this.cboPHONGBAN.DataSource = listphongban;
            this.cboPHONGBAN.DisplayMember = "TENPB";
            this.cboPHONGBAN.ValueMember = "MAPHONGBAN";
        }
        private void loadData()
        {

            DBcontext context = new DBcontext();
            List<NHANVIEN> listnhanhvien = context.NHANVIENs.ToList();
            List<CHINHANH> listchinhanh = context.CHINHANHs.ToList();
            List<PHONGBAN> listphongban = context.PHONGBANs.ToList();
            PhongbanchinhanhCombobox(listphongban, listchinhanh);
            BindGrid(listnhanhvien);

        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txtTEN.Text;

            dgvNhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvNhanvien.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(searchValue))
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
            string cl = "Vua moi:" + btn_timkiem.Text +","+"nhân viên:" +txtTEN.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCHUCVU.Text == "ADMIN")
                {
                    MessageBox.Show("BẠN KHÔNG THỂ XÓA TÀI KHOẢN NÀY", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DBcontext context = new DBcontext();
                    NHANVIEN delete = context.NHANVIENs.FirstOrDefault(p => p.MANV == txtMANV.Text);
                    if (delete == null)
                        throw new Exception("Không tìm thấy dữ liệu để xóa");
                    DialogResult dig = MessageBox.Show("Bạn có muốn xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dig == DialogResult.Yes)
                    {
                        context.NHANVIENs.Remove(delete);
                        context.SaveChanges();
                        BindGrid(context.NHANVIENs.ToList());
                    }
                    loadData();
                }
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
            string cl = "Vua moi:" + btnXoa.Text +"," +"nhân viên: "+txtTEN.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            string gioitinh;
            if (radNAM.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            nv.MANV = txtMANV.Text;
            nv.HOTENNV = txtTEN.Text;
            nv.NGAYSINH = dtpNGAYSINH.Value;
            nv.GIOITINH = gioitinh;
            nv.CHUCVU = txtCHUCVU.Text;
            nv.LUONGCB = txtLUONG.Text;
            nv.MAPHONGBAN = string.Format(cboPHONGBAN.SelectedValue.ToString());
            nv.MACHINHANH = string.Format(cboCHINHANH.SelectedValue.ToString());
            DBcontext context = new DBcontext();
            NHANVIEN dbUpdate = context.NHANVIENs.FirstOrDefault(p => p.MANV == nv.MANV);
            if (dbUpdate != null)
            {
                dbUpdate.MANV = nv.MANV;
                dbUpdate.HOTENNV = nv.HOTENNV;
                dbUpdate.NGAYSINH = nv.NGAYSINH;
                dbUpdate.GIOITINH = nv.GIOITINH;
                dbUpdate.CHUCVU = nv.CHUCVU;
                dbUpdate.LUONGCB = nv.LUONGCB;
                dbUpdate.MAPHONGBAN = nv.MAPHONGBAN;
                dbUpdate.MACHINHANH = nv.MACHINHANH;
                context.SaveChanges(); //lưu thay đổi
                MessageBox.Show("Cập nhật thành công");
            }
            loadData();
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vua moi:" + bntSua.Text+","+ "nhân viên: "+txtTEN.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string manv = dgvNhanvien.SelectedRows[0].Cells[0].Value + "";
                DBcontext context = new DBcontext();
                NHANVIEN dgv = context.NHANVIENs.FirstOrDefault(p => p.MANV == manv);
                if (dgv != null)
                {
                    txtMANV.Text = dgv.MANV;
                    txtTEN.Text = dgv.HOTENNV;
                    dtpNGAYSINH.Text = dgv.NGAYSINH.ToString();
                    txtCHUCVU.Text = dgv.CHUCVU;
                    txtLUONG.Text = dgv.LUONGCB;
                    cboPHONGBAN.SelectedValue = string.Format(dgv.MAPHONGBAN.ToString());
                    cboCHINHANH.SelectedValue = string.Format(dgv.MACHINHANH.ToString());
                }
            }
            catch 
            {
                MessageBox.Show("Vui lòng nhấp ô bên trái ngoài cùng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}