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
using System.Security.Cryptography;

using pjQLLNV;


namespace pjQLLNV
{
    public partial class Login : Form
    {
        Model1 db = new Model1();
        public Login()
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

        public void vegeMahoa2(ref StringBuilder s2, string key2)
        {
            for (int i = 0; i < s2.Length; i++) s2[i] = char.ToUpper(s2[i]);
            key2 = key2.ToUpper();
            int j = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                if (char.IsLetter(s2[i]))
                {
                    s2[i] = (char)((s2[i]) + key2[j] - 'A');
                    if (s2[i] > 'Z') s2[i] = (char)(s2[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key2.Length ? 0 : j + 1;
            }
        }
        public void vegeMahoa3(ref StringBuilder s3, string key3)
        {
            for (int i = 0; i < s3.Length; i++) s3[i] = char.ToUpper(s3[i]);
            key3 = key3.ToUpper();
            int j = 0;
            for (int i = 0; i < s3.Length; i++)
            {
                if (char.IsLetter(s3[i]))
                {
                    s3[i] = (char)((s3[i]) + key3[j] - 'A');
                    if (s3[i] > 'Z') s3[i] = (char)(s3[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key3.Length ? 0 : j + 1;
            }
        }
        public void vegeMahoa4(ref StringBuilder s4, string key4)
        {
            for (int i = 0; i < s4.Length; i++) s4[i] = char.ToUpper(s4[i]);
            key4 = key4.ToUpper();
            int j = 0;
            for (int i = 0; i < s4.Length; i++)
            {
                if (char.IsLetter(s4[i]))
                {
                    s4[i] = (char)((s4[i]) + key4[j] - 'A');
                    if (s4[i] > 'Z') s4[i] = (char)(s4[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key4.Length ? 0 : j + 1;
            }
        }


        /*
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
        */


        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;

        public void dangnhap()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
            try
            {
           
                con.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string mk2 = label1.Text;
                string mk3 = label2.Text;
                string mk4 = label3.Text;

                string sql = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "' or TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk2 + "' or TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk3 + "' or TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk4 + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {

                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
                    Chon add = new Chon();
                    string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
                    da = new SqlDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds, "TAIKHOANADM");
                    table = ds.Tables["TAIKHOANADM"];




                    if (table.Rows.Count == 0)
                    {

                        this.Hide();

                        add.temp = txtTK.Text;
                        add.ShowDialog();
                        this.Close();
                    }  // khong co dong nao
                    else
                    {



                        DateTime time = DateTime.Now;
                        lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");

                        LICHSU nv = new LICHSU();
                        nv.TAIKHOAN = txtTK.Text.Trim();
                        nv.THOIGIAN = lbTG.Text.Trim();
                        nv.THAOTAC = btnLogin.Text.Trim();
                        db.LICHSUs.Add(nv);
                        db.SaveChanges();

                        this.Hide();
                        add.temp = txtTK.Text;
                        add.ShowDialog();
                        this.Close();
                    }

                }

            }


            catch (Exception)
            {
                lbThongbao.Text = "Lỗi kết nối";
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            label1.Text = txtMK.Text;
            label2.Text = txtMK.Text;
            label3.Text = txtMK.Text;
            //  txtMK.Text = GetMD5(txtMK.Text);
            Random rand1 = new Random();
            int num1 = rand1.Next(1, 5);

            StringBuilder s = new StringBuilder(txtMK.Text);
            string key = "hi";
            vegeMahoa(ref s, key);
            txtMK.Text = Convert.ToString(s);


            StringBuilder s2 = new StringBuilder(label1.Text);
            string key2 = "luong";
            vegeMahoa2(ref s2, key2);
            label1.Text = Convert.ToString(s2);

            StringBuilder s3 = new StringBuilder(label2.Text);
            string key3 = "thanh";
            vegeMahoa3(ref s3, key3);
            label2.Text = Convert.ToString(s3);

            StringBuilder s4 = new StringBuilder(label3.Text);
            string key4 = "tuan";
            vegeMahoa2(ref s4, key4);
            label3.Text = Convert.ToString(s4);




            dangnhap();

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
                this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }


    
}
