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

namespace Phan_mem_ngan_hang
{
    public partial class Danhsachchinhanhcongty : DevExpress.XtraEditors.XtraUserControl
    {
        private static Danhsachchinhanhcongty _dscongty;
        public static Danhsachchinhanhcongty dscongty
        {
            get
            {
                if (_dscongty == null)
                {
                    _dscongty = new Danhsachchinhanhcongty();

                }
                return _dscongty;

            }
        }
        public Danhsachchinhanhcongty()
        {
            InitializeComponent();
        }
        private void BindGrid(List<CHINHANH> listchinhanh)
        {
            dgv_dschinhanh.Rows.Clear();
            foreach (var item in listchinhanh)
            {
                int a = dgv_dschinhanh.Rows.Add();
                dgv_dschinhanh.Rows[a].Cells[0].Value = item.MACHINHANH;
                dgv_dschinhanh.Rows[a].Cells[1].Value = item.TENCHINHANH;
                dgv_dschinhanh.Rows[a].Cells[2].Value = item.DIACHI;
            }
        }
        private void loadData()
        {

            DBcontext context = new DBcontext();
            List<CHINHANH> listchinhanh = context.CHINHANHs.ToList();
            BindGrid(listchinhanh);

        }
        private void Danhsachchinhanhcongty_Load(object sender, EventArgs e)
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
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            try
            {
                DBcontext context = new DBcontext();
                CHINHANH cnh = new CHINHANH();
                if (txt_machinhanh.Text.Trim() == "" || txt_tenchinhanh.Text.Trim() == "" || txt_diachi.Text.Trim() == "")
                {

                    throw new Exception("Vui lòng nhập thông tin đầy đủ");
                }
                    //CHINHANH cn = new CHINHANH();
                    cnh.MACHINHANH = txt_machinhanh.Text;
                    cnh.TENCHINHANH = txt_tenchinhanh.Text;
                    cnh.DIACHI = txt_diachi.Text;
                    //DBcontext context = new DBcontext();
                    CHINHANH finDB = context.CHINHANHs.FirstOrDefault(p => p.MACHINHANH == cnh.MACHINHANH);
                    if (finDB == null)
                    {
                        context.CHINHANHs.Add(cnh);
                        context.SaveChanges();
                    }
                    DateTime tg = DateTime.Now;
                    //Model2 giamsat = new Model2();

                    CHECKLOG t = new CHECKLOG();
                    string thoigian = tg.ToString();
                    t.THOIGIAN = tg.ToString();
                    DBcontext context1 = new DBcontext();
                    string cl = "Vua moi:" + btn_them.Text + " " + "danh sách công ty: " + txt_tenchinhanh.Text;
                    Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
                    n.h();
                    string tnd = "" + n.h();
                    t.TENTK = tnd;
                    t.NOIDUNG = cl;
                    t.THOIGIAN = thoigian;

                    context1.CHECKLOGs.Add(t);
                    context1.SaveChanges();
                    loadData();
                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();
            
            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vừa mới:" + btn_them.Text +" "+ "danh sách công ty: " + txt_tenchinhanh.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();*/

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                CHINHANH cn = new CHINHANH();
                if (txt_machinhanh.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập mã chi nhánh công ty");
                }
                    cn.MACHINHANH = txt_machinhanh.Text;
                    cn.TENCHINHANH = txt_tenchinhanh.Text;
                    cn.DIACHI = txt_diachi.Text;
                    DBcontext context = new DBcontext();
                    CHINHANH dbUpdate = context.CHINHANHs.FirstOrDefault(p => p.MACHINHANH == cn.MACHINHANH);
                    if (dbUpdate != null)
                    {
                        dbUpdate.MACHINHANH = cn.MACHINHANH;
                        dbUpdate.TENCHINHANH = cn.TENCHINHANH;
                        dbUpdate.DIACHI = cn.DIACHI;
                        context.SaveChanges(); //lưu thay đổi
                        MessageBox.Show("Sửa thành công!!!");
                     }
                        loadData();
                
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vua moi:" + btn_sua.Text +" " + "danh sách công ty"+txt_tenchinhanh.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }

        private void dgv_dschinhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string MACHINHANH = dgv_dschinhanh.SelectedRows[0].Cells[0].Value + "";
                DBcontext context = new DBcontext();
                CHINHANH dgv = context.CHINHANHs.FirstOrDefault(p => p.MACHINHANH == MACHINHANH);
                if (dgv != null)
                {
                    txt_machinhanh.Text = dgv.MACHINHANH;
                    txt_tenchinhanh.Text = dgv.TENCHINHANH;
                    txt_diachi.Text = dgv.DIACHI;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhấp phía bên trái ngoài cùng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DBcontext context = new DBcontext();
                CHINHANH delete = context.CHINHANHs.FirstOrDefault(p => p.MACHINHANH == txt_machinhanh.Text);
                if (delete == null)
                {
                    throw new Exception("Không tìm thấy dữ liệu xóa");
                }
                DialogResult dig = MessageBox.Show("Bạn có muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dig == DialogResult.Yes)
                {
                    context.CHINHANHs.Remove(delete);
                    context.SaveChanges();
                    BindGrid(context.CHINHANHs.ToList());
                }
                loadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime tg = DateTime.Now;
            //Model2 giamsat = new Model2();

            CHECKLOG t = new CHECKLOG();
            string thoigian = tg.ToString();
            t.THOIGIAN = tg.ToString();
            DBcontext context1 = new DBcontext();
            string cl = "Vua moi:" + btn_xoa.Text + " " + "danh sách công ty"+txt_tenchinhanh.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
