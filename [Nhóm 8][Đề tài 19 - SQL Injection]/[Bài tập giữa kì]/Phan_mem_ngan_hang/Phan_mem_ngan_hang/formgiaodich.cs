using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Phan_mem_ngan_hang
{
    public partial class formgiaodich : DevExpress.XtraEditors.XtraUserControl
    {
        DBcontext context = new DBcontext();

        private static int a1;
        private static int a2;
        private static int a3;
        private static int a5;
        private static int a4 = 0;
        private static formgiaodich _fgiaodich;
        public static formgiaodich fgiaodich
        {
            get
            {
                if (_fgiaodich == null)
                {
                    _fgiaodich = new formgiaodich();
                }
                return _fgiaodich;
            }
        }
        public formgiaodich()
        {
            InitializeComponent();
        }
        private void LoadCmb()
        {
            List<LOAIGIAODICH> listmaloai = context.LOAIGIAODICHes.ToList();
            LoadCmbMaloai(listmaloai);
        }

        private void LoadCmbMaloai(List<LOAIGIAODICH> listmaloai)
        {
            this.cmbLoaiGD.DataSource = listmaloai;
            this.cmbLoaiGD.DisplayMember = "TENLOAI";
            this.cmbLoaiGD.ValueMember = "MALOAI";
        }
        private void LoadData()
        {

            List<GIAODICH> listgiaodich = context.GIAODICHes.ToList();
            LoadDL(listgiaodich);
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                sb.Append(c);
            }
            if (lowerCase)
            {
                return sb.ToString().ToLower();
            }
            return sb.ToString();
        }
        private string timMaKH()
        {
            return txtMaKH.Text = "SELECT MAKH FROM  KHACHHANG WHERE HOTEN like '%" + txtHovaten.Text.Trim() + "%'";
        }
        public void LoadDL(List<GIAODICH> listgiaodich)
        {
            dgvGiaodich.Rows.Clear();


            foreach (var item in listgiaodich)
            {
                int indext = dgvGiaodich.Rows.Add();
                dgvGiaodich.Rows[indext].Cells[0].Value = item.MAGD;
                dgvGiaodich.Rows[indext].Cells[1].Value = item.NGAYGD;
                dgvGiaodich.Rows[indext].Cells[2].Value = item.GIOGD;
                dgvGiaodich.Rows[indext].Cells[3].Value = item.NOIDUNG;
                dgvGiaodich.Rows[indext].Cells[4].Value = item.SOTIEN;
                dgvGiaodich.Rows[indext].Cells[5].Value = item.HINHTHUCGD;
                dgvGiaodich.Rows[indext].Cells[6].Value = item.LOAIGIAODICH.TENLOAI;
                dgvGiaodich.Rows[indext].Cells[7].Value = item.MANV;
                dgvGiaodich.Rows[indext].Cells[9].Value = item.SOTK;
                dgvGiaodich.Rows[indext].Cells[8].Value = item.MAKH;


            }
        }
        private void formgiaodich_Load(object sender, EventArgs e)
        {
            LoadCmb();
            LoadData();
            txtMaGD.Text = RandomString(10, false);
            txtGio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void Cleartxt()

        {
            txtHovaten.Text = "";
            txtGio.Text = "";
            txtNoidung.Text = "";
            txtMaKH.Text = "";
            txtSotien.Text = "";
            txtMaGD.Text = "";
            txtSotk.Text = "";
            txtTknhan.Text = "";
            txtMaNV.Text = "";
            cmbHinhthuc.SelectedItem = false;
            cmbLoaiGD.SelectedValue = false;
        }
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            GIAODICH GD = new GIAODICH();
            try
            {
                if (txtHovaten.Text.Trim() == string.Empty ||
                    txtMaKH.Text.Trim() == string.Empty ||
                    txtSotk.Text.Trim() == string.Empty ||
                    txtSotien.Text.Trim() == string.Empty
                   )
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");

                }
                
                GD.MAGD = txtMaGD.Text;
                //  DateTime ngaykt = DateTime.Parse(txtNgay.Text);
                GD.NGAYGD = dateTimePicker1.Value;
                TimeSpan time = TimeSpan.Parse(txtGio.Text);
                GD.GIOGD = time;
                GD.HINHTHUCGD = cmbHinhthuc.SelectedItem.ToString();

                string a = string.Format(cmbLoaiGD.SelectedValue.ToString());
                GD.MALOAI = a;
                GD.SOTK = txtSotk.Text;
                GD.NOIDUNG = txtNoidung.Text;
                GD.MANV = txtMaNV.Text;
                GD.MAKH = txtMaKH.Text;
                GD.SOTK = txtSotk.Text;
                GD.NOIDUNG = txtNoidung.Text;
                GD.MANV = txtMaNV.Text;
                GD.MAKH = txtMaKH.Text;
                GD.SOTIEN = txtSotien.Text;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /*GIAODICH GD = new GIAODICH();
            GD.MAGD = txtMaGD.Text;
            //  DateTime ngaykt = DateTime.Parse(txtNgay.Text);
            GD.NGAYGD = dateTimePicker1.Value;
            TimeSpan time = TimeSpan.Parse(txtGio.Text);
            GD.GIOGD = time;
            GD.HINHTHUCGD = cmbHinhthuc.SelectedItem.ToString();

            string a = string.Format(cmbLoaiGD.SelectedValue.ToString());
            GD.MALOAI = a;
            GD.SOTK = txtSotk.Text;
            GD.NOIDUNG = txtNoidung.Text;
            GD.MANV = txtMaNV.Text;
            GD.MAKH = txtMaKH.Text;
            GD.SOTK = txtSotk.Text;
            GD.NOIDUNG = txtNoidung.Text;
            GD.MANV = txtMaNV.Text;
            GD.MAKH = txtMaKH.Text;
            GD.SOTIEN = txtSotien.Text;*/

            try
            {
                string a = string.Format(cmbLoaiGD.SelectedValue.ToString());
                if (a == "NT")

                {
                    TAIKHOAN tim = context.TAIKHOANs.FirstOrDefault(p => p.MAKH == txtMaKH.Text);
                    if (tim != null)
                    {

                        a1 = int.Parse(tim.SODU);
                        string m = txtSotien.Text;
                        a1 = a1 + int.Parse(m);
                        tim.SODU = a1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại tài khoản");
                    }

                }

                if (a == "CT")
                {
                    do
                    {


                        if (txtTknhan.Text.Trim() != string.Empty)
                        {
                            TAIKHOAN tim = context.TAIKHOANs.FirstOrDefault(p => p.MAKH == txtMaKH.Text);
                            string n = txtTknhan.Text;
                            a1 = int.Parse(tim.SODU);
                            string m = txtSotien.Text;
                            if (a1 >= int.Parse(m))
                            {


                                a2 = a1 - int.Parse(m);
                                tim.SODU = a2.ToString();
                                TAIKHOAN timtkn = context.TAIKHOANs.FirstOrDefault(p => p.SOTK == txtTknhan.Text);
                                a3 = int.Parse(timtkn.SODU);
                                a5 = a3 + int.Parse(m);
                                timtkn.SODU = a5.ToString();
                                a4 = 1;


                            }
                            else
                            {
                                MessageBox.Show("Số dư tài khoản không đủ!!");

                            }

                        }
                        else
                        {

                            MessageBox.Show("Vui long nhập tài khoản người nhận", "Thông báo");

                            frmThemtkn m = new frmThemtkn();

                            m.ShowDialog();
                            txtTknhan.Text = m.m();


                        }
                    } while (txtTknhan.Text.Trim() != string.Empty && a4 == 0);
                }






                if (a == "RT")
                {


                    TAIKHOAN tim = context.TAIKHOANs.FirstOrDefault(p => p.MAKH == txtMaKH.Text);
                    a1 = int.Parse(tim.SODU);
                    string m = txtSotien.Text;
                    if (a1 >= int.Parse(m))
                    {

                        a1 = a1 - int.Parse(m);
                        tim.SODU = a1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số dư tài khoản không đủ!!");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }


            //GIAODICH GD = new GIAODICH();
            context.GIAODICHes.Add(GD);
            context.SaveChanges();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
            LoadData();
            Cleartxt();

            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vừa mới:" + btnLuu.Text + "thông tin giao dịch khách hàng: "+txtHovaten.Text;
            Dang_Nhap_Nhan_Vien x = new Dang_Nhap_Nhan_Vien();
            x.h();
            string tnd = "" + x.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }



        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

            KHACHHANG tim = context.KHACHHANGs.FirstOrDefault(p => p.HOTEN == txtHovaten.Text);
            if (tim != null)
            {
                txtMaKH.Text = tim.MAKH;
            }
            else
            {
                txtMaKH.Text = "null";
            }
        }

        private void txtSotk_TextChanged(object sender, EventArgs e)
        {
            TAIKHOAN tim = context.TAIKHOANs.FirstOrDefault(p => p.MAKH == txtMaKH.Text);
            if (tim != null)
            {
                txtSotk.Text = tim.SOTK;
            }
            else
            {
                txtSotk.Text = "null";

            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            KHACHHANG tim = context.KHACHHANGs.FirstOrDefault(p => p.SOCMND == txtCMND.Text);
            if (tim != null)
            {
                txtHovaten.Text = tim.HOTEN;
                txtMaKH.Text = tim.MAKH;
            }
            else
            {
                txtMaKH.Text = "null";
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }



        private void txtHotenNV_TextChanged(object sender, EventArgs e)
        {

            NHANVIEN tim = context.NHANVIENs.FirstOrDefault(p => p.HOTENNV == txtHotenNV.Text);
            if (tim != null)
            {
                txtMaNV.Text = tim.MANV;
            }
            else
            {
                txtSotk.Text = "null";
            }

        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vừa mới:" + btnIn.Text + "thông tin giao dịch khách hàng: "+txtHovaten.Text;
            Dang_Nhap_Nhan_Vien x = new Dang_Nhap_Nhan_Vien();
            x.h();
            string tnd = "" + x.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }
    }
}
