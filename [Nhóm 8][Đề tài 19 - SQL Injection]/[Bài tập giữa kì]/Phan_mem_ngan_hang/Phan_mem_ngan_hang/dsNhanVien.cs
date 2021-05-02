using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;


namespace Phan_mem_ngan_hang
{
    
    public partial class dsNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        string TENTK = "", HOTENNV = "", MATKHAU = "", CHUCVU = "";
        private static dsNhanVien _dsnhanvien;
        public static dsNhanVien dsnhanvien
        {
            get
            {
                if (_dsnhanvien == null)
                {
                    _dsnhanvien = new dsNhanVien();
                }
                return _dsnhanvien;
            }
        }
        //public class dsnv:GiaoDien01
        //{
        //}
        
        //public dsNhanVien()
        //{
        //    InitializeComponent();

        //}

        public dsNhanVien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BindGrid(List<NHANVIEN> listNhanvien)
        {
            dgvNhanvien.Rows.Clear();
            foreach (var item in listNhanvien)
            {
                int a = dgvNhanvien.Rows.Add();
                dgvNhanvien.Rows[a].Cells[0].Value = item.MANV;
                dgvNhanvien.Rows[a].Cells[1].Value = item.HOTENNV;
                dgvNhanvien.Rows[a].Cells[2].Value = item.NGAYSINH;
                dgvNhanvien.Rows[a].Cells[3].Value = item.GIOITINH;

                dgvNhanvien.Rows[a].Cells[4].Value = item.PHONGBAN.TENPB;
                dgvNhanvien.Rows[a].Cells[5].Value = item.CHUCVU;
                dgvNhanvien.Rows[a].Cells[6].Value = item.LUONGCB;
                dgvNhanvien.Rows[a].Cells[7].Value = item.CHINHANH.TENCHINHANH;
            }
        }
        private void loadData()
        {
            DBcontext context = new DBcontext();
            List<NHANVIEN> listNhanvien = context.NHANVIENs.ToList();
            BindGrid(listNhanvien);
        }
        private void dsNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btn_themnhanvien_Click(object sender, EventArgs e)
        {
            //if (CHUCVU =="Trưởng Phòng")
            //{


                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RL8FVB7;Initial Catalog=QLNH;Integrated Security=True");
                //SqlDataAdapter da = new SqlDataAdapter("Select * from NHANVIEN", conn);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                Them_NV themnv = new Them_NV(/*dt.Rows[0][6].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][4].ToString()*/);
                themnv.ShowDialog();
                loadData();
            //}
            //else
            //{
            //    MessageBox.Show("Khong duoc dung chuc nang nay");
            //}
            
            
                
                
            

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            btn_timkiemNhanvien timnv = new btn_timkiemNhanvien();
            timnv.ShowDialog();
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //internal void BringToFront(/*string v1, string v2, string v3,*/ string v4)
        //{
        //    throw new NotImplementedException();
        //    //this.TENTK = v1;
        //    //this.HOTENNV = v2;
        //    //this.MATKHAU = v3;
        //    this.CHUCVU = v4;
        //}
    }
}
