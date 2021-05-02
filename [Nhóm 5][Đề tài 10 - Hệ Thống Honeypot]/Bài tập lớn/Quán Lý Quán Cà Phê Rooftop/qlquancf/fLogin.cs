using qlquancf.DAO;
using qlquancf.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlquancf
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        Account n = new Account();
        Model1 t = new Model1();
        checklog u = new checklog();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {

                label3.Text = "Nguoidung(" +userName + "), vuamoi: " + btnLogin.Text;
                //   lbtaikhoan.Text = DangNhap.user;
                DateTime time = DateTime.Now;
                // DateTime time = DateTime.Now;
                string b = time.ToString("dd/MM/yyyy, HH:mm:ss");
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                
                this.Hide();

                f.ShowDialog();
               
                this.Show();
                u.ngay = b;
                u.noidung = label3.Text.Trim();
                
                t.checklogs.Add(u);
                t.SaveChanges();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        }
        
        bool Login(string userName, string passWord)
        {

            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo " , MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {

                e.Cancel = true;
            }
        }
    }
}
