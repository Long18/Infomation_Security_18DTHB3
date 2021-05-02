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
using lancuoi;
using System.Data.SqlClient;

namespace lancuoi
{
    public partial class dangki : Form
    {
        public dangki()
        {
            InitializeComponent();
        }


        Model1 db = new Model1();
        int vt = -1;

        private void LoadNV()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
            con.Open();
            con.Close();
            string sql = "SELECT * FROM TAIKHOAN UNION ALL SELECT *FROM TAIKHOANADM";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvTK.DataSource = ds.Tables[0];
            dgvTK.Refresh();

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


        private void btnThem_Click(object sender, EventArgs e)
        {




            lbMess.Text = "";
            try
            {
                var NV = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txtTK.Text).FirstOrDefault();
                if (txtTK.Text == "" || txtMK.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                if (NV != null)
                    lbMess.Text = "Tài khoản đã tồn tại";
                TAIKHOAN nv = new TAIKHOAN();


                StringBuilder s = new StringBuilder(txtMK.Text);
                string key = "hi";
                vegeMahoa(ref s, key);
                txtMK.Text = Convert.ToString(s);


                nv.TAIKHOAN1 = txtTK.Text.Trim();
                nv.MATKHAU = txtMK.Text.Trim();
                nv.KIEMSOAT = comboBox1.Text.Trim();


                db.TAIKHOANs.Add(nv);
                db.SaveChanges();
                LoadNV();
                SetTextEmpty();
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



            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

            lbMess.Text = " ";
            try
            {
                if (txtTK.Text == "" || txtMK.Text == "")
                    lbMess.Text = "Chưa nhập đủ thông tin";
                TAIKHOAN sv = db.TAIKHOANs.Where(p => p.TAIKHOAN1 == txtTK.Text).FirstOrDefault();

                StringBuilder s = new StringBuilder(txtMK.Text);
                string key = "hi";
                vegeMahoa(ref s, key);
                txtMK.Text = Convert.ToString(s);

                sv.TAIKHOAN1 = txtTK.Text.Trim();
                sv.MATKHAU = txtMK.Text.Trim();
                sv.KIEMSOAT = comboBox1.Text.Trim();

                db.Entry(sv).State = EntityState.Modified;
                db.SaveChanges();
                txtMK.Clear();
                LoadNV();
                SetTextEmpty();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }







        }

        private void btnXoa_Click(object sender, EventArgs e)
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

            }
            else
            {
                lbMess.Text = "Chưa chọn tài khoản";

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
                comboBox1.Text =dgvTK.Rows[vt].Cells["KIEMSOAT"].Value.ToString();

            }

            StringBuilder s = new StringBuilder(txtMK.Text);
            string key = "hi";
            vegaGM(ref s, key);
            txtMK.Text = Convert.ToString(s);
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void dangki_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void dgvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnqlnv_Click(object sender, EventArgs e)
        {
            quanlinhanvien add = new quanlinhanvien();
            add.ShowDialog();
        }
    }
    
}
