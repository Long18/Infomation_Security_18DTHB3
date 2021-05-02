using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using pjQLLNV;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace pjQLLNV
{


    public partial class qlTK : Form
    {
        Model1 db = new Model1();
       
        int vt = -1;
        public qlTK()
        {
            InitializeComponent();
        }
        private void LoadNV()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
            con.Open();
            con.Close();
            string sql = "SELECT * FROM TAIKHOAN";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvTK.DataSource = ds.Tables[0];
            dgvTK.Refresh();





        }
        private void qlTK_Load(object sender, EventArgs e)
        {
            LoadNV();
            lbTK.Text = temp2;

        }
        public string temp2;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;


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
      /*  private String GetMD5(string txt)
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            lbMess.Text = txtMK.Text;
            lbTK3.Text = txtMK.Text;
            lbQLTK.Text = txtMK.Text;
            try
            {


                var NV = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txtTK.Text).FirstOrDefault();
                if (txtTK.Text == "" || txtMK.Text == "" || cbb1.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                if (NV != null)
                    lbMess.Text = "Tài khoản đã tồn tại";
                TAIKHOAN nv = new TAIKHOAN();


                


                Random rand1 = new Random();
                int num1 = rand1.Next(1,4);

                StringBuilder s = new StringBuilder(txtMK.Text);
                string key = "hi";
                vegeMahoa(ref s, key);
                txtMK.Text = Convert.ToString(s);


                StringBuilder s2 = new StringBuilder(lbMess.Text);
                string key2 = "luong";
                vegeMahoa2(ref s2, key2);
                lbMess.Text = Convert.ToString(s2);

                StringBuilder s3 = new StringBuilder(lbTK3.Text);
                string key3 = "thanh";
                vegeMahoa3(ref s3, key3);
                lbTK3.Text = Convert.ToString(s3);

                StringBuilder s4 = new StringBuilder(lbQLTK.Text);
                string key4 = "tuan";
                vegeMahoa2(ref s4, key4);
                lbQLTK.Text = Convert.ToString(s4);

                //   txtMK.Text = GetMD5(txtMK.Text);



                if (num1 == 1)
                {
                    nv.TAIKHOAN1 = txtTK.Text.Trim();
                    nv.MATKHAU = txtMK.Text.Trim();
                    nv.QUYEN = cbb1.Text.Trim();
                    nv.KIEMSOAT = cbbKS.Text.Trim();
                    db.TAIKHOANs.Add(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();

                }
                if(num1 == 2)
                {
                    nv.TAIKHOAN1 = txtTK.Text.Trim();
                    nv.MATKHAU = lbMess.Text.Trim();
                    nv.QUYEN = cbb1.Text.Trim();
                    nv.KIEMSOAT = cbbKS.Text.Trim();
                    db.TAIKHOANs.Add(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();

                }

                if (num1 == 3)
                {
                    nv.TAIKHOAN1 = txtTK.Text.Trim();
                    nv.MATKHAU = lbTK3.Text.Trim();
                    nv.QUYEN = cbb1.Text.Trim();
                    nv.KIEMSOAT = cbbKS.Text.Trim();
                    db.TAIKHOANs.Add(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();

                }
                if (num1 == 4)
                {
                    nv.TAIKHOAN1 = txtTK.Text.Trim();
                    nv.MATKHAU = lbQLTK.Text.Trim();
                    nv.QUYEN = cbb1.Text.Trim();
                    nv.KIEMSOAT = cbbKS.Text.Trim();
                    db.TAIKHOANs.Add(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();

                }


                lbMess.Text = "";
                lbTK3.Text = "Tài khoản của bạn:";
                lbQLTK.Text = "QUẢN LÝ TÀI KHOẢN";


                string tk = lbTK.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
                Chon add = new Chon();
                string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOANADM");
                table = ds.Tables["TAIKHOANADM"];




                if (table.Rows.Count != 0)
                {




                    DateTime time = DateTime.Now;
                    lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                    LICHSU na = new LICHSU();
                    na.TAIKHOAN = lbTK.Text.Trim();
                    na.THOIGIAN = lbTG.Text.Trim();
                    na.THAOTAC = btnThem.Text.Trim();
                    db.LICHSUs.Add(na);
                    db.SaveChanges();

                    lbTG.Text = "";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void SetTextEmpty()
        {
            txtMK.Clear();
            txtTK.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

  

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");


            lbMess.Text = txtMK.Text;
            lbTK3.Text = txtMK.Text;
            lbQLTK.Text = txtMK.Text;
            try
            {
                if (txtTK.Text == "" || txtMK.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                TAIKHOAN sv = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txtTK.Text).FirstOrDefault();

                //


                Random rand1 = new Random();
                int num1 = rand1.Next(1, 5);


                StringBuilder s2 = new StringBuilder(lbMess.Text);
                string key2 = "luong";
                vegeMahoa2(ref s2, key2);
                lbMess.Text = Convert.ToString(s2);

                StringBuilder s3 = new StringBuilder(lbTK3.Text);
                string key3 = "thanh";
                vegeMahoa3(ref s3, key3);
                lbTK3.Text = Convert.ToString(s3);

                StringBuilder s4 = new StringBuilder(lbQLTK.Text);
                string key4 = "tuan";
                vegeMahoa2(ref s4, key4);
                lbQLTK.Text = Convert.ToString(s4);

                //   txtMK.Text = GetMD5(txtMK.Text);



                if (num1 == 1)
                {
                    sv.TAIKHOAN1 = txtTK.Text.Trim();
                    sv.MATKHAU = txtMK.Text.Trim();
                    sv.QUYEN = cbb1.Text.Trim();
                    sv.KIEMSOAT = cbbKS.Text.Trim();
                    db.Entry(sv).State = EntityState.Modified;
                    db.SaveChanges();
                    txtMK.Clear();
                    LoadNV();
                    SetTextEmpty();

                }
                if (num1 == 2)
                {
                    sv.TAIKHOAN1 = txtTK.Text.Trim();
                    sv.MATKHAU = lbMess.Text.Trim();
                    sv.QUYEN = cbb1.Text.Trim();
                    sv.KIEMSOAT = cbbKS.Text.Trim();
                    db.Entry(sv).State = EntityState.Modified;
                    db.SaveChanges();
                    txtMK.Clear();
                    LoadNV();
                    SetTextEmpty();

                }

                if (num1 == 3)
                {
                    sv.TAIKHOAN1 = txtTK.Text.Trim();
                    sv.MATKHAU = lbTK3.Text.Trim();
                    sv.QUYEN = cbb1.Text.Trim();
                    sv.KIEMSOAT = cbbKS.Text.Trim();
                    db.Entry(sv).State = EntityState.Modified;
                    db.SaveChanges();
                    txtMK.Clear();
                    LoadNV();
                    SetTextEmpty();

                }
                if (num1 == 4)
                {
                    sv.TAIKHOAN1 = txtTK.Text.Trim();
                    sv.MATKHAU = lbQLTK.Text.Trim();
                    sv.QUYEN = cbb1.Text.Trim();
                    sv.KIEMSOAT = cbbKS.Text.Trim();
                    db.Entry(sv).State = EntityState.Modified;
                    db.SaveChanges();
                    txtMK.Clear();
                    LoadNV();
                    SetTextEmpty();

                }


                lbMess.Text = "";
                lbTK3.Text = "Tài khoản của bạn:";
                lbQLTK.Text = "QUẢN LÝ TÀI KHOẢN";

                //








               






                string tk = lbTK.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
                Chon add = new Chon();
                string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOANADM");
                table = ds.Tables["TAIKHOANADM"];




                if (table.Rows.Count != 0)
                {

                    DateTime time = DateTime.Now;
                    lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                    LICHSU na = new LICHSU();
                    na.TAIKHOAN = lbTK.Text.Trim();
                    na.THOIGIAN = lbTG.Text.Trim();
                    na.THAOTAC = btnSua.Text.Trim();
                    db.LICHSUs.Add(na);
                    db.SaveChanges();

                    lbTG.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        

      


            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == lbTK.Text)
            {
                ThongBao ok = new ThongBao();
                ok.temp6 = "Vẫn xóa";
                ok.ShowDialog();
            
            }
            else
            {
                if (vt >= 0 && vt < dgvTK.Rows.Count)
                {
                    lbMess.Text = "";
                    var NV = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txtTK.Text).FirstOrDefault();
                    TAIKHOAN nv = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txtTK.Text).FirstOrDefault();
                    db.TAIKHOANs.Remove(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();
                    vt = -1;





                    string tk = lbTK.Text;
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
                    Chon add = new Chon();
                    string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
                    da = new SqlDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds, "TAIKHOAN");
                    table = ds.Tables["TAIKHOAN"];




                    if (table.Rows.Count != 0)
                    {

                        DateTime time = DateTime.Now;
                        lbTG.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                        LICHSU na = new LICHSU();
                        na.TAIKHOAN = lbTK.Text.Trim();
                        na.THOIGIAN = lbTG.Text.Trim();
                        na.THAOTAC = btnXoa.Text.Trim();
                        db.LICHSUs.Add(na);
                        db.SaveChanges();

                        lbTG.Text = "";
                    }











                }
                else
                {
                    lbMess.Text = "Chưa chọn tài khoản";

                }

            }



     
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt >= 0 && vt < dgvTK.Rows.Count)
            {
                txtTK.Text = dgvTK.Rows[vt].Cells["TAIKHOAN"].Value.ToString();
                txtMK.Text = dgvTK.Rows[vt].Cells["MATKHAU"].Value.ToString();
                cbb1.Text = dgvTK.Rows[vt].Cells["QUYEN"].Value.ToString();
                cbbKS.Text = dgvTK.Rows[vt].Cells["KIEMSOAT"].Value.ToString();



            }

            StringBuilder s = new StringBuilder(txtMK.Text);
            string key = "hi";
            vegaGM(ref s, key);
            txtMK.Text = Convert.ToString(s);
        }


        public Boolean isExists(String name)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        //Xem form con đó đang mở hay gì 
        public void activeChildForm(String name)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    f.Activate();
                    return;
                }
            }
        }


        private void lịchSửTruyCậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("ReportLichsu"))
            {
                ReportLichsu frm = new ReportLichsu();
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("ReportLichsu");
            }
        }

        private void dgvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void đổiMậtKhẩuADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoimkADM add = new DoimkADM();
            add.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
