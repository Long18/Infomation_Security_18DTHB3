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
using System.Security.Cryptography;

namespace Phan_mem_ngan_hang
{
    public partial class DoiMatKhau : DevExpress.XtraEditors.XtraUserControl
    {
        private static DoiMatKhau _doimatkhau;
        public static DoiMatKhau doimatkhau
        {
            get
            {
                if (_doimatkhau == null)
                {
                    _doimatkhau = new DoiMatKhau();
                }
                return _doimatkhau;
            }
        }
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        private void loadData()
        {

            DBcontext context = new DBcontext();
            List<NHANVIEN> listnhanhvien = context.NHANVIENs.ToList();


        }
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RL8FVB7;Initial Catalog=QLNH;Integrated Security=True");
        private void btn_luu_Click(object sender, EventArgs e)
        {




            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txt_mkcu.Text.ToString());
            txt_mkcu.Text = Hash(passtohash);
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) from NHANVIEN where TENTK = N'" +txt_tendangnhap.Text + "' and MATKHAU = N'" + txt_mkcu.Text + "' ",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();

            if(dt.Rows[0][0].ToString() == "1")
            {
                if (txt_mkmoi.Text == txt_nhaplaimkmoi.Text)
                {
                    if (txt_mkmoi.TextLength >= 6)//đổi mật khảu ký tự phải từ 6 trở lên
                    {
                        //lưu thời gian thay đổi mk
                        NHANVIEN nv = new NHANVIEN();
                        //DateTime tg = DateTime.Now;
                        //nv.thoigiandoimatkhau = tg;
                        //nv.TENTK = txt_tendangnhap.Text;
                        DBcontext context = new DBcontext();
                        NHANVIEN dbUpdate = context.NHANVIENs.FirstOrDefault(p => p.TENTK == nv.TENTK);
                        if (dbUpdate != null)
                        {

                            dbUpdate.thoigiandoimatkhau = nv.thoigiandoimatkhau;
                            context.SaveChanges();
                        }
                        loadData();

                        //
                        byte[] passtohash1 = System.Text.Encoding.UTF8.GetBytes(txt_mkmoi.Text.ToString());
                        txt_mkmoi.Text = Hash(passtohash1);
                        SqlDataAdapter da1 = new SqlDataAdapter("update NHANVIEN set MATKHAU = N'" + txt_mkmoi.Text + "' where TENTK = N'" + txt_tendangnhap.Text + "' and MATKHAU = N'" + txt_mkcu.Text + "'", cn);//kiểm tra lỗi từ dòng này
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);//đến dòng này

                    }
                    else
                    {
                        errorProvider1.SetError(txt_mkmoi,"Độ dài mật khẩu không đủ(Phải nhập từ 6 ký tự trở lên)");
                    }
                }
                else
                {
                    errorProvider1.SetError(txt_mkmoi, "Bạn chưa điền mật khẩu");
                    errorProvider1.SetError(txt_nhaplaimkmoi, "Mật khẩu nhập lại chưa đúng");
                }
            }
            else
            {
                errorProvider1.SetError(txt_tendangnhap,"Tên ngưởi đăng nhập không đúng");
                errorProvider1.SetError(txt_mkcu,"Mật khẩu cũ không đúng ");
            }
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vua moi:" + btn_luu.Text + "mat khau moi";
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();

        }
        public String Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
