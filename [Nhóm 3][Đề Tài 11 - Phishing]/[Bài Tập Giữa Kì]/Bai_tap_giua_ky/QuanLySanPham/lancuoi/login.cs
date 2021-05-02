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
using System.Data.Entity;
using lancuoi;

namespace lancuoi
{
    public partial class login : Form
    {
        Model1 db = new Model1();
        public login()
        {
            InitializeComponent();
        }


        public void vigenereMahoa(ref StringBuilder s, string key)
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

        public void vigenereMahoa2(ref StringBuilder s, string key)
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

        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
            try
            {
                StringBuilder s = new StringBuilder(txtmatkhau.Text);
                string key = "hi";
                vigenereMahoa(ref s, key);
                txtmatkhau.Text = Convert.ToString(s);
                con.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;

                Trangchu add = new Trangchu();



                string sql = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "' UNION ALL select * from TAIKHOANADM where TAIKHOANADM = '" + tk + "' and MATKHAUADM = '" + mk + "'  ";
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




                        add.temp = txttaikhoan.Text;
                        add.ShowDialog();
                        this.Hide();
                        this.Close();
                    }  // khong co dong nao
                    else
                    {

                        add.temp = txttaikhoan.Text;

                        DateTime time = DateTime.Now;
                        lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");

                        LICHSU nv = new LICHSU();
                        nv.TAIKHOAN = txttaikhoan.Text.Trim();
                        nv.THOIGIAN = lbTG.Text.Trim();
                        nv.NOIDUNG = btndangnhap.Text.Trim();
                        db.LICHSUs.Add(nv);
                        db.SaveChanges();






                        add.ShowDialog();

                    
                        this.Hide();
                        this.Close();
                    }



                }





            }
            catch (Exception)
            {
                lbTG.Text = "Lỗi kết nối";
            }

        }
    }
}
