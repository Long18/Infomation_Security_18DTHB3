using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Security.Cryptography;//MD5 để add thư viện



namespace FORMCHINH
{
    public partial class frmdangnhap : DevExpress.XtraEditors.XtraForm
    {
        DANGNHAP s = new DANGNHAP();

        public frmdangnhap()
        {
            InitializeComponent();
        }
       
        
        private void frmdangnhap_Load(object sender, EventArgs e)
        {
        }
        /*public DANGNHAP check (string tk)
        {
            Model2 context = new Model2();
            List<DANGNHAP> listdangnhap = context.DANGNHAPs.ToList();
            foreach (DANGNHAP a in  listdangnhap)
            {
                if(tk ==dn.TAIKHOAN)
                {
                    DANGNHAP db = context.DANGNHAPs.FirstOrDefault(p => p.TAIKHOAN == tk);
                    return db;
                }
            }
            return null;
        }*/
        Model23 t = new Model23();
        checklog u = new checklog();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection ("Data Source=.\\SQLEXPRESS;Initial Catalog=QLVLXD;Integrated Security=True");
            try
            {
                s.MATKHAU = txtmatkhau.Text;
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("" + s.MATKHAU.ToString());
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                conn.Open();
                string tk = txttaikhoan.Text;
                string sql = "select * from DANGNHAP where TAIKHOAN='"+tk+"' and MATKHAU='"+sb.ToString()+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
               
                if(dta.Read()==true)
                {
                    string v = "nguoi dunng" + txttaikhoan.Text + " vua moi" + btndangnhap.Text;
                    DateTime time = DateTime.Now;
                    string b = time.ToString("đ/MM/yyy, HH:mm:ss");
                    MessageBox.Show("Đăng nhâp thành công");
                    Form1 f = new Form1();
                    u.ngay = b;
                    u.noidung = v;
                    t.checklogs.Add(u);
                    t.SaveChanges();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndk_Click(object sender, EventArgs e)
        {
            frmdk f = new frmdk();
            f.Show();
        }
    }
}