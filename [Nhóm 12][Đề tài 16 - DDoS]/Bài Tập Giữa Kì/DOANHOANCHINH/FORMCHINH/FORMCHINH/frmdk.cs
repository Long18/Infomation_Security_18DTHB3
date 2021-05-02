using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Security.Cryptography;


namespace FORMCHINH
{
    public partial class frmdk : DevExpress.XtraEditors.XtraForm
    {
        public frmdk()
        {
            InitializeComponent();
        }
        
        private void bthdangki_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttk.Text.Trim() == "" || txtmk.Text.Trim() == "" || txtxnmk.Text.Trim() == "")
                {
                    throw new Exception("Vui long nhap day du thong tin");
                }
                Model2 context = new Model2();
                List<DANGNHAP> ListLogin = context.DANGNHAPs.ToList();
                LOAITAIKHOAN L = new LOAITAIKHOAN();
                DANGNHAP s = new DANGNHAP();
                L.LOAITK = txtloaitk.Text;
                s.TAIKHOAN = txttk.Text;
                s.MATKHAU = txtmk.Text;
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("" + s.MATKHAU.ToString());
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                s.MATKHAU = sb.ToString();

                DANGNHAP FindDB = context.DANGNHAPs.FirstOrDefault(p => p.TAIKHOAN == s.TAIKHOAN);


                if (FindDB == null)
                {

                    if (s.TAIKHOAN != txttk.Text)
                    {
                        MessageBox.Show(" Tài Khoản Đã Có Người Đặt ", "Thông Báo");
                    }
                    else
                    {
                        if (txtmk.Text == txtxnmk.Text)
                        {
                            Model23 t = new Model23();
                           // Model23 u = new Model23();
                            checklog u = new checklog();
                            string v = "Người Dùng " + txttk.Text + " Vừa Mới " + bthdangki.Text;
                            DateTime time = DateTime.Now;
                            string b = time.ToString("dd/MM/yyy, HH:mm:ss");
                            u.ngay = b;
                            u.noidung = v;
                            t.checklogs.Add(u);
                            t.SaveChanges();
                            context.DANGNHAPs.Add(s);

                            MessageBox.Show("tao tk thanh cong.", "Thông Báo");
                            textBox1.Text = s.MATKHAU.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Mat khau nhap lai khong khop!!!");
                            txtmk.Text = "";
                            txtxnmk.Text = "";
                        }
                    }
                }


                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string _salt = "X2";
        

        private void frmdk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void loaitk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtloaitk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}