using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
//using BLL;

namespace Phan_mem_ngan_hang
{
    public partial class Dang_Nhap_Nhan_Vien : DevExpress.XtraEditors.XtraForm
    {
        
        //KHOA_BLL = new KHOA_BLL();

        public bool Islogin { get; set; }
        public Dang_Nhap_Nhan_Vien()
        {
            InitializeComponent();
            Islogin = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc chắn Muốn Thoát ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            
        }
        private void loadData()
        {
            //Model2 context1 = new Model2();
            //List<checklog> checklogs = context1.checklogs.ToList();
            DBcontext context = new DBcontext();
            List<CHECKLOG> listchecklog = context.CHECKLOGs.ToList();
            //List<NHANVIEN> listnhanhvien = context.NHANVIENs.ToList();


        }
        public string h()
        {
            string hs = txt_tk.Text;
            return hs;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            
            //mã hóa 
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txt_mk.Text.ToString());

            txt_mk.Text = Hash(passtohash);
            
            //kết nối database
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RL8FVB7;Initial Catalog=QLNH;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from NHANVIEN where TENTK = N'" + txt_tk.Text + "'and MATKHAU = N'" + txt_mk.Text + "'",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >0)
            {
                //lưu thời gian đăng nhập vào phần mềm
                NHANVIEN nv = new NHANVIEN();
                DateTime tg = DateTime.Now;
                //-----------------------------------------------------
                //Model2 giamsat = new Model2();
                CHECKLOG t = new CHECKLOG();
                string thoigian = tg.ToString();
              //  t.Noidung = btn_dangnhap.Text;
                t.THOIGIAN = tg.ToString();
                //------------------------------
                //string thoigian = tg.ToString();
                //nv.thoigiandangnhap = tg;
                //nv.TENTK = txt_tk.Text;
                DBcontext context = new DBcontext();
                //checklog dbUpdate = context.checklogs.FirstOrDefault(p => p.Noidung == t.Noidung);
                //NHANVIEN dbUpdate = context.NHANVIENs.FirstOrDefault(p => p.TENTK == nv.TENTK);
                //Model2 context1 = new Model2();
                //checklog dbUpdate1 = context1.checklogs.FirstOrDefault(q => q.Noidung == t.Noidung);
                //----------------------------------------------------------------
               /* if (dbUpdate != null)
                {

                    dbUpdate.Noidung = t.Noidung;
                    dbUpdate.Thoigian = t.Thoigian;
                    context.SaveChanges();
                    //dbUpdate.thoigiandangnhap = nv.thoigiandangnhap;
                    //context.SaveChanges();
                }
                loadData();*/
                
                MessageBox.Show("Đăng Nhập Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //code ẩn đóng giao diện thành công

                this.Hide();
                Giaodien01 gd = new Giaodien01(dt.Rows[0][6].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString());
                //---------------------------------------------------------------

                string cl = ("Vua moi: Dang Nhap");
                string tnd = "" + txt_tk.Text;
                //cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t.TENTK = tnd;
                t.NOIDUNG = cl;
                
                t.THOIGIAN = thoigian;
                

                context.CHECKLOGs.Add(t);
                context.SaveChanges();
                //----------------------------------------------------------------
                //7285
                gd.ShowDialog();
                Islogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại.(Vui lòng nhập lại)");
            }
            
        }

        private void Dang_Nhap_Nhan_Vien_Load(object sender, EventArgs e)
        {

        }

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {
            
        }
        //ham ma hoa
        public String Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }    
        }
    }
}
