using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lancuoi
{
    public partial class dangnhapadmin : Form
    {
        public dangnhapadmin()
        {
            InitializeComponent();
        }

        public void vegeMahoa(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    s[i] = (char)((s[i]) + key[j] - 'A');
                    if (s[i] > 'Z') s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
            try
            {
                StringBuilder s = new StringBuilder(txtmatkhau.Text);
                string key = "hi";
                vegeMahoa(ref s, key);
                txtmatkhau.Text = Convert.ToString(s);
                con.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sql = "select * from TAIKHOANADM where TAIKHOANADM = '" + tk + "' and MATKHAUADM = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    this.Hide();

                    dangki add = new dangki();

                    add.ShowDialog();
                    this.Close();
                }

                else
                {
                    lbthongbao.Text = "Sai thông tin đăng nhập";
                }
            }
            catch (Exception)
            {
                lbthongbao.Text = "Lỗi kết nối";
            }

        }

    

    private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
