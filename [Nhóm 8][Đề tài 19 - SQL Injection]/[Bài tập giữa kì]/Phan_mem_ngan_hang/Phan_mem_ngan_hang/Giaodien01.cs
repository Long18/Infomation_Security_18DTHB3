using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phan_mem_ngan_hang
{
    public partial class Giaodien01 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        string TENTK = "", CHUCVU = "", MATKHAU = "", PHONGBAN = "";

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            if(CHUCVU == "ADMIN")
            {
                if (!Container2.Controls.Contains(dsNhanVien.dsnhanvien))
                {
                    Container2.Controls.Add(dsNhanVien.dsnhanvien);
                    dsNhanVien.dsnhanvien.Dock = DockStyle.Fill;
                    dsNhanVien.dsnhanvien.BringToFront();
                }
                dsNhanVien.dsnhanvien.BringToFront();
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền sử dụng chức năng này","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (PHONGBAN == "PGD" || CHUCVU == "Chủ Tịch" || CHUCVU =="ADMIN" ||CHUCVU =="Nhân viên")
            {
                if (!Container2.Controls.Contains(DsKhachHang.dskhachhang))
                {
                    Container2.Controls.Add(DsKhachHang.dskhachhang);
                    DsKhachHang.dskhachhang.Dock = DockStyle.Fill;
                    DsKhachHang.dskhachhang.BringToFront();
                }
                DsKhachHang.dskhachhang.BringToFront();
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if (PHONGBAN == "PGD"|| CHUCVU == "Chủ Tịch" || CHUCVU == "Nhân viên" || CHUCVU == "ADMIN")
            {
                if (!Container2.Controls.Contains(formgiaodich.fgiaodich))
                {
                    Container2.Controls.Add(formgiaodich.fgiaodich);
                    formgiaodich.fgiaodich.Dock = DockStyle.Fill;
                    formgiaodich.fgiaodich.BringToFront();
                }
                formgiaodich.fgiaodich.BringToFront();
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền sử dụng chức năng này","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }    
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (!Container2.Controls.Contains(DoiMatKhau.doimatkhau))
            {
                Container2.Controls.Add(DoiMatKhau.doimatkhau);
                DoiMatKhau.doimatkhau.Dock = DockStyle.Fill;
                DoiMatKhau.doimatkhau.BringToFront();
            }
            DoiMatKhau.doimatkhau.BringToFront();
        }
        private void loadData()
        {

            DBcontext context = new DBcontext();
            List<NHANVIEN> listnhanhvien = context.NHANVIENs.ToList();


        }
        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muôn đăng xuất ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //lưu thời gian thay đổi mk
                NHANVIEN nv = new NHANVIEN();
                DateTime tg = DateTime.Now;
                nv.thoigiandangxuat = tg;
                //this.MANV = nv.MANV;
                //nv.TENTK = txt_tendangnhap.Text;
                DBcontext context = new DBcontext();
                NHANVIEN dbUpdate = context.NHANVIENs.FirstOrDefault(p => p.TENTK == nv.TENTK);
                if (dbUpdate != null)
                {

                    dbUpdate.thoigiandangxuat = nv.thoigiandangxuat;
                    context.SaveChanges();
                }
                loadData();

                //
                this.Close();
                CHECKLOG t = new CHECKLOG();
                string thoigian = tg.ToString();
                t.THOIGIAN = tg.ToString();
                DBcontext context1 = new DBcontext();
                string cl = "Vừa mới:" + accordionControlElement4.Text + "," + "khỏi phần mềm";
                Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
                n.h();
                string tnd = "" + n.h();
                t.TENTK = tnd;
                t.NOIDUNG = cl;
                t.THOIGIAN = thoigian;

                context1.CHECKLOGs.Add(t);
                context1.SaveChanges();
            }
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (CHUCVU =="Chủ Tịch" || CHUCVU == "ADMIN")
            {
                if(!Container2.Controls.Contains(Danhsachchinhanhcongty.dscongty))
                {
                    Container2.Controls.Add(Danhsachchinhanhcongty.dscongty);
                    Danhsachchinhanhcongty.dscongty.Dock = DockStyle.Fill;
                    Danhsachchinhanhcongty.dscongty.BringToFront();
                }
                Danhsachchinhanhcongty.dscongty.BringToFront();
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền sử dụng chức năng này","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help.ShowHelp(this, @"D:\Downloads\Do_An\Phan_mem_ngan_hang\Phan_mem_ngan_hang\filehelp\huongdansudungphanmem.chm");
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            //trang dành cho admin quản lý
            if (CHUCVU == "ADMIN")
            {
                if (!Container2.Controls.Contains(form_Admin.admin1))
                {
                    Container2.Controls.Add(form_Admin.admin1);
                    form_Admin.admin1.Dock = DockStyle.Fill;
                    form_Admin.admin1.BringToFront();
                }
                form_Admin.admin1.BringToFront();
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void Container2_Click(object sender, EventArgs e)
        {

        }

        private void Giaodien01_Load(object sender, EventArgs e)
        {

        }

        public Giaodien01()
        {
            InitializeComponent();
        }
        public Giaodien01(string TENTK, string CHUCVU, string MATKHAU, string PHONGBAN)
        {
            InitializeComponent();
            this.TENTK = TENTK;
            this.CHUCVU = CHUCVU;
            this.MATKHAU = MATKHAU;
            this.PHONGBAN = PHONGBAN;
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            if (!Container2.Controls.Contains(Trangchu.trangchu))
            {
                Container2.Controls.Add(Trangchu.trangchu);
                Trangchu.trangchu.Dock = DockStyle.Fill;
                Trangchu.trangchu.BringToFront();
            }
            Trangchu.trangchu.BringToFront();
        }
    }
}
