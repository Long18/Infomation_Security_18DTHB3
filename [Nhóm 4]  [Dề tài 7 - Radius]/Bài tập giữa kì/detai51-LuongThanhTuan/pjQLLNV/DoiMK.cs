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

using pjQLLNV;

namespace pjQLLNV
{

    public partial class DoiMK : Form
    {
        Model1 db = new Model1();
      
        public DoiMK()
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

        static void vegaGM(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                              (char)(s[i] - key[j] + 'A') :
                              (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }

        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;
        private void btnMK_Click(object sender, EventArgs e)
        {



            StringBuilder s = new StringBuilder(txtMK.Text);
            string key = "hi";
            vegeMahoa(ref s, key);
            txtMK.Text = Convert.ToString(s);

            StringBuilder s2 = new StringBuilder(txtMKm.Text);
            string key2 = "hi";
            vegeMahoa2(ref s2, key2);
            txtMKm.Text = Convert.ToString(s2);



            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
            try
            {


                con.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    if (txtMKm.Text == "")
                        lbThongbao.Text = "Chưa nhập đủ thông tin";
                    TAIKHOAN sv = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txtTK.Text).FirstOrDefault();

      

                    sv.TAIKHOAN1 = txtTK.Text.Trim();
                    sv.MATKHAU = txtMKm.Text.Trim();
                    db.Entry(sv).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    lbThongbao.Text = "Đổi mật khẩu thành công";







                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
                    Chon add = new Chon();
                    string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
                    da = new SqlDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds, "TAIKHOANADM");
                    table = ds.Tables["TAIKHOANADM"];




                    if (table.Rows.Count != 0)
                    {
                        lbThaotac.Text = "Đổi mật khẩu";
                        DateTime time = DateTime.Now;
                        lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");

                        LICHSU nv = new LICHSU();
                        nv.TAIKHOAN = txtTK.Text.Trim();
                        nv.THOIGIAN = lbTG.Text.Trim();
                        nv.THAOTAC = lbThaotac.Text.Trim();
                        db.LICHSUs.Add(nv);
                        db.SaveChanges();
                    }  
          












     





                    txtMK.Clear();
                    txtMKm.Clear();

                    lbTG.Text = "";

                    lbThaotac.Text = "";
                    lbTK.Text = "";

                }

                else
                {
                    lbThongbao.Text = "Sai thông tin đăng nhập";
                    txtMK.Clear();
                    txtMKm.Clear();
                }
            }
            catch (Exception)
            {
                lbThongbao.Text = "Lỗi kết nối";
                txtMK.Clear();
                txtMKm.Clear();
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
