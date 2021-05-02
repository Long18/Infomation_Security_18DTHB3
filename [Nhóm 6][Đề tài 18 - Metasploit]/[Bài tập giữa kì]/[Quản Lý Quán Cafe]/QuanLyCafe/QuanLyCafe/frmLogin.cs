using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DAO;
using QuanLyCafe.DTO;

namespace QuanLyCafe
{
    public partial class frmLogin : Form
    {
        public String Username= "admin";
        public String Password= "admin";


        public static string CIP = "";
        public static string EmpNo = "1";
        public static string username = "1";
        SqlConnection con = main.GetDBConnection();

        

        private void getIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily.ToString() == "InterNetwork")
                {
                    CIP = ip.ToString();
                }
            }
            lblCP.Text = CIP;
        }


        public bool IsLoggedIn(string Username, string Password)
        {
            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Nhập Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (this.Username == Username && this.Password == Password)
            {

                return true;
            }
            MessageBox.Show("Sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
            getIP();
          

        }
        



        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();

            string login = "login";
            if (AccountAdminDAO.Instance.Login(txtUsername.Text, txtPassword.Text))
            {
               
                main code = new main();
              //   DataProvider.Instance.ExecuteQuery(@"INSERT INTO User_Activity_Log VALUES ('" + Convert.ToString(txtUsername.Text) + "','" + EmpNo + "','" + DateTime.Now + "','" + login + "','" + CIP + "')");
                code.excute(@"INSERT INTO User_Activity_Log VALUES ('" + Convert.ToString(txtUsername.Text) + "','" + EmpNo + "','" + DateTime.Now + "','" + login + "','" + CIP + "')");
               
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
