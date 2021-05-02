using qlquancf.DAO;
using qlquancf.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlquancf
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            txbUseName.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;
        }
        
        Account n = new Account();
        Model1 t = new Model1();
        checklog u = new checklog();
        void UpdateAccountInfo()
        {

            string a = "nguoidung: " + txbDisplayName.Text + ", vuamoivao: " + btnUpdate.Text;
            //   lbtaikhoan.Text = DangNhap.user;
            DateTime time = DateTime.Now;
            // DateTime time = DateTime.Now;
            string b = time.ToString("dd/MM/yyyy, HH:mm:ss");
            string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPass.Text;
            string reenterPass = txbReEnterPass.Text;
            string userName = txbUseName.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                    u.ngay = b;
                    u.noidung = a;
                    t.checklogs.Add(u);
                    t.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu");
                }
            }
        }
        //Truyền dữ liệu từ con sang cha(khi cập nhật thành công tự động cập nhật luôn không cần đăng xuất)
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void txbUseName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    //Level 2 của Event
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
