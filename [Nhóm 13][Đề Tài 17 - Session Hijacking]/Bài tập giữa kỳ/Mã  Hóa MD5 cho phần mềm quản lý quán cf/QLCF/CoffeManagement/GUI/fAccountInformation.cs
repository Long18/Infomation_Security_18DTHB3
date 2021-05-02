using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

using DTO;
using BUS;

namespace GUI
{
    public partial class fAccountInformation : DevExpress.XtraEditors.XtraForm
    {
        private Account loginAccount;
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccountInformation(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
        }

        private void UpdateAccount()
        {
            string displayName = txtDisplayName.Text;
            string password = CreateMD5(txtPassword.Text);
            string newPass = txtNewPassword.Text;
            string retypePass = txtReTypePass.Text;
            string userName = txtUserName.Text;

            if (!newPass.Equals(retypePass))
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                string en_crypt = CreateMD5(newPass);
                if (AccountBUS.Instance.UpdateInformation(userName, displayName, password, en_crypt))
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Cập nhật thành công");
                    Log.WriteLog("change account's information");
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAccountInformation_Load(object sender, EventArgs e)
        {

        }
    }
}