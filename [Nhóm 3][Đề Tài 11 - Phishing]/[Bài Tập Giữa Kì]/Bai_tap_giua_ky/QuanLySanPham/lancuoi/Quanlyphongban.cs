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
    public partial class Quanlyphongban : Form
    {
        public Quanlyphongban()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
       int vt = -1;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadNV()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True";
            con.Open();
            con.Close();
            string sql = "SELECT * FROM PHONGBAN";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvpb.DataSource = ds.Tables[0];
            dgvpb.Refresh();
        }
        private SqlDataAdapter da;
        private DataSet ds;
       private DataTable table;
        private void btnthem_Click(object sender, EventArgs e)
        {
            lbMess.Text = "";
            try
            {
                
                string tk = lbtk.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

                string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "'  and KIEMSOAT = 'bat' UNION ALL select * from TAIKHOANADM where TAIKHOANADM = '" + tk + "'  and KIEMSOAT = 'bat'  ";

                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOAN");
                table = ds.Tables["TAIKHOAN"];




                if (table.Rows.Count == 0)
                {
                    var NV = db.PHONGBANs.Where(p => p.MAPB == txtmapb.Text).FirstOrDefault();
                    if (txtmapb.Text == "" || txtmapb.Text == "")
                        lbMess.Text = "Chưa nhập đủ thông tin";
                    if (NV != null)
                        lbMess.Text = "Phòng ban đã tồn tại";
                    PHONGBAN nv = new PHONGBAN();

                    nv.MAPB = txtmapb.Text.Trim();
                    nv.TENPB = txttenpb.Text.Trim();

                    db.PHONGBANs.Add(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();
                }  // khong co dong nao
                else
                {

                    var NV = db.PHONGBANs.Where(p => p.MAPB == txtmapb.Text).FirstOrDefault();
                    if (txtmapb.Text == "" || txtmapb.Text == "")
                        lbMess.Text = "Chưa nhập đủ thông tin";
                    if (NV != null)
                        lbMess.Text = "Phòng ban đã tồn tại";
                    PHONGBAN nv = new PHONGBAN();

                    nv.MAPB = txtmapb.Text.Trim();
                    nv.TENPB = txttenpb.Text.Trim();

                    db.PHONGBANs.Add(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();
                    lbND.Text = "Thêm phòng ban";
                    DateTime time = DateTime.Now;
                    lbtime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
               
                    LICHSU na = new LICHSU();
                    na.TAIKHOAN = lbtk.Text.Trim();
                    na.THOIGIAN = lbtime.Text.Trim();
                    na.NOIDUNG = lbND.Text.Trim();
                    db.LICHSUs.Add(na);
                    db.SaveChanges();
                    lbND.Text = "";
             



                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

          private void SetTextEmpty()
            {
                txtmapb.Clear();
                txttenpb.Clear();
            }
        
        private void btnsua_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

            lbMess.Text = " ";
            try
            {
                string tk = lbtk.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

                string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "'  and KIEMSOAT = 'bat' UNION ALL select * from TAIKHOANADM where TAIKHOANADM = '" + tk + "'  and KIEMSOAT = 'bat'  ";

                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOAN");
                table = ds.Tables["TAIKHOAN"];

                if (table.Rows.Count == 0)
                {




                    if (txtmapb.Text == "" || txttenpb.Text == "")
                        lbMess.Text = "Chưa nhập đủ thông tin";
                    PHONGBAN sa = db.PHONGBANs.Where(p => p.MAPB == txtmapb.Text).FirstOrDefault();

                    sa.MAPB = txtmapb.Text.Trim();
                    sa.TENPB = txttenpb.Text.Trim();
       
                    db.Entry(sa).State = EntityState.Modified;
                    db.SaveChanges();
                    txtmapb.Clear();
                    txttenpb.Clear();
                    LoadNV();
                  
                }  // khong co dong nao
                else
                {





                    if (txtmapb.Text == "" || txttenpb.Text == "")
                        lbMess.Text = "Chưa nhập đủ thông tin";
                    PHONGBAN sv = db.PHONGBANs.Where(p => p.MAPB == txtmapb.Text).FirstOrDefault();

                    sv.MAPB = txtmapb.Text.Trim();
                    sv.TENPB = txttenpb.Text.Trim();

                    db.Entry(sv).State = EntityState.Modified;
                    db.SaveChanges();
                    txtmapb.Clear();
                    txttenpb.Clear();
                    LoadNV();



                    lbND.Text = "Sửa phòng ban";
                    DateTime time = DateTime.Now;
                    lbtime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");

                    LICHSU na = new LICHSU();
                    na.TAIKHOAN = lbtk.Text.Trim();
                    na.THOIGIAN = lbtime.Text.Trim();
                    na.NOIDUNG = lbND.Text.Trim();
                    db.LICHSUs.Add(na);
                    db.SaveChanges();
                    lbND.Text = "";




                }















               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

      



       

        private void Quanlyphongban_Load_1(object sender, EventArgs e)
        {

            LoadNV();
            lbtk.Text = hello;
        }
        public string hello;

        private void dgvpb_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt >= 0 && vt < dgvpb.Rows.Count)
            {
                txtmapb.Text = dgvpb.Rows[vt].Cells["MAPB"].Value.ToString();
                txttenpb.Text = dgvpb.Rows[vt].Cells["TENPB"].Value.ToString();


            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (vt >= 0 && vt < dgvpb.Rows.Count)
            {

                string tk = lbtk.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J4D22FE\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

                string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "'  and KIEMSOAT = 'bat' UNION ALL select * from TAIKHOANADM where TAIKHOANADM = '" + tk + "'  and KIEMSOAT = 'bat'  ";

                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOAN");
                table = ds.Tables["TAIKHOAN"];

                if (table.Rows.Count == 0)
                {


                    lbMess.Text = "";
                    var NV = db.PHONGBANs.Where(p => p.MAPB == txtmapb.Text).FirstOrDefault();
                    PHONGBAN nv = db.PHONGBANs.Where(p => p.MAPB == txtmapb.Text).FirstOrDefault();
                    db.PHONGBANs.Remove(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();
                    vt = -1;
                }  // khong co dong nao
                else
                {





                    lbMess.Text = "";
                    var NV = db.PHONGBANs.Where(p => p.MAPB == txtmapb.Text).FirstOrDefault();
                    PHONGBAN nv = db.PHONGBANs.Where(p => p.MAPB == txtmapb.Text).FirstOrDefault();
                    db.PHONGBANs.Remove(nv);
                    db.SaveChanges();
                    LoadNV();
                    SetTextEmpty();
                    vt = -1;



                    lbND.Text = "Xóa phòng ban";
                    DateTime time = DateTime.Now;
                    lbtime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");

                    LICHSU na = new LICHSU();
                    na.TAIKHOAN = lbtk.Text.Trim();
                    na.THOIGIAN = lbtime.Text.Trim();
                    na.NOIDUNG = lbND.Text.Trim();
                    db.LICHSUs.Add(na);
                    db.SaveChanges();
                    lbND.Text = "";




                }







            }
            else
            {
                lbMess.Text = "Chưa chọn tài khoản";

            }
        }
    }
}
