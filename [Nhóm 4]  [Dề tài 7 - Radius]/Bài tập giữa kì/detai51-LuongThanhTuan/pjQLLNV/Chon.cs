using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace pjQLLNV
{
    
    public partial class Chon : Form
    {
        Model1 db = new Model1();
        public Chon()
        {
            InitializeComponent();
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
     

        private void Chon_Load(object sender, EventArgs e)
        {
            toolMenu.Text = temp;
        }
        public string temp;
        private void btnQltt_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.ShowDialog();
        }


      

        private void quảnLýThôngTinNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("Form1"))
            {
                Form1 frm = new Form1();
                frm.temp3 = toolMenu.Text;

                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("Form1");
            }
        }

        private void quảnLýDanhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("qlSP"))
            {
                qlSP frm = new qlSP();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("qlSP");
            }
        }


        private void quảnLýThôngTinPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("qlPB"))
            {
                qlPB frm = new qlPB();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("qlPB");
            }
        }

        private void tínhLươngNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("FormTinhL"))
            {
                FormTinhL frm = new FormTinhL();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("FormTinhL");
            }
        }

        private void xemBảngLươngNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("XemLuong"))
            {
                XemLuong frm = new XemLuong();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("XemLuong");
            }
        }

        private void menuuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {



            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");

            Chon add = new Chon();
            string tk = toolMenu.Text;


            string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and QUYEN = 'admin' ";
        
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "TAIKHOANADM");
            table = ds.Tables["TAIKHOANADM"];



            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Bạn không phải là admin");
            }  // khong co dong nao
            else
            {


                if (!isExists("qlPB"))
                {
                    qlTK ac = new qlTK();

                    ac.temp2 = toolMenu.Text;

                    ac.MdiParent = this;
                    ac.Dock = DockStyle.Fill;
                    ac.Show();

               
                }
                else
                {
                    activeChildForm("qlPB");
                }
            
            }




        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tk = toolMenu.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MN1DH84\SQLEXPRESS;Initial Catalog=sqlQLLSP;Integrated Security=True");
            Login add = new Login();
            string query = "select * from TAIKHOAN where TAIKHOAN = '" + tk + "' and KIEMSOAT like '%bat'";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "TAIKHOANADM");
            table = ds.Tables["TAIKHOANADM"];




            if (table.Rows.Count == 0)
            {

                this.Hide();
                
                add.ShowDialog();
                this.Close();
            }  // khong co dong nao
            else
            {

                đổiMậtKhẩuToolStripMenuItem.Text = "";
                DateTime time = DateTime.Now;
                đổiMậtKhẩuToolStripMenuItem.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");
                LICHSU nv = new LICHSU();
                nv.TAIKHOAN = toolMenu.Text.Trim();
                nv.THOIGIAN = đổiMậtKhẩuToolStripMenuItem.Text.Trim();
                nv.THAOTAC = đăngXuấtToolStripMenuItem.Text.Trim();
                db.LICHSUs.Add(nv);
                db.SaveChanges();



                this.Hide();
                add.ShowDialog();
                this.Close();
            }




        }



        private void tìmKiếmNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("Timkiem"))
            {
                Timkiem frm = new Timkiem();
                frm.temp4 = toolMenu.Text;


                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("Timkiem");
            }
        }

        private void reportBảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("Report"))
            {
                Report frm = new Report();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("Report");
            }
        }

        private void reportDanhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("ReportDsNV"))
            {
                ReportDsNV frm = new ReportDsNV();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("ReportDsNV");
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExists("DoiMK"))
            {
                DoiMK frm = new DoiMK();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("DoiMK");
            }
        }
    }
}
