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
    public partial class doimatkhau2 : Form
    {

        Model1 db = new Model1();
        Model1 dc = new Model1();
        public doimatkhau2()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTK_Click(object sender, EventArgs e)
        {

        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;
        private void btntaomatkhau_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(txtmatkhau.Text);
            string key = "hi";
            vegeMahoa(ref s, key);
            txtmatkhau.Text = Convert.ToString(s);

            StringBuilder s2 = new StringBuilder(txtmatkhaumoi.Text);
            string key2 = "hi";
            vegeMahoa2(ref s2, key2);
            txtmatkhaumoi.Text = Convert.ToString(s2);



            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
            try
            {


                con.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sql = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "' UNION ALL select * from TAIKHOANADM where TAIKHOANADM = '" + tk + "' and MATKHAUADM = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {




                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

                    string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "' and KIEMSOAT = 'bat' UNION ALL select * from TAIKHOANADM where TAIKHOANADM = '" + tk + "' and MATKHAUADM = '" + mk + "' and KIEMSOAT = 'bat'  ";

                    da = new SqlDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds, "TAIKHOAN");
                    table = ds.Tables["TAIKHOAN"];




                    if (table.Rows.Count == 0)
                    {
                        if (txtmatkhaumoi.Text == "")
                            lbthongbao.Text = "Chưa nhập đủ thông tin";
                        TAIKHOAN sv = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txttaikhoan.Text).FirstOrDefault();


                        sv.TAIKHOAN1 = txttaikhoan.Text.Trim();
                        sv.MATKHAU = txtmatkhaumoi.Text.Trim();
                        db.Entry(sv).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        lbthongbao.Text = "Đổi mật khẩu thành công";
                        txtmatkhau.Clear();
                        txtmatkhaumoi.Clear();
                    }  // khong co dong nao
                    else
                    {

                        if (txtmatkhaumoi.Text == "")
                            lbthongbao.Text = "Chưa nhập đủ thông tin";
                        TAIKHOAN sv = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txttaikhoan.Text).FirstOrDefault();


                        sv.TAIKHOAN1 = txttaikhoan.Text.Trim();
                        sv.MATKHAU = txtmatkhaumoi.Text.Trim();
                        db.Entry(sv).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        lbthongbao.Text = "Đổi mật khẩu thành công";
                        txtmatkhau.Clear();
                        txtmatkhaumoi.Clear();

                        DateTime time = DateTime.Now;
                        lbtime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                        lbnoidung2.Text = "Doi mat khau";
                        LICHSU nv = new LICHSU();
                        nv.TAIKHOAN = txttaikhoan.Text.Trim();
                        nv.THOIGIAN = lbtime.Text.Trim();
                        nv.NOIDUNG = lbnoidung2.Text.Trim();
                        db.LICHSUs.Add(nv);
                        db.SaveChanges();

                        lbnoidung2.Text = "";



                    }
                }
            }
            catch (Exception)
            {
                lbthongbao.Text = "Lỗi kết nối";
                txtmatkhau.Clear();
                txtmatkhaumoi.Clear();
            }
        }

        private void lbnoidung2_Click(object sender, EventArgs e)
        {

        }

        private void doimatkhau2_Load(object sender, EventArgs e)
        {

        }
    }
}
