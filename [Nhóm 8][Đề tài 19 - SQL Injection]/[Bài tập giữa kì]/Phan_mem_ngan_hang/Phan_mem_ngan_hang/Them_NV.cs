using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Phan_mem_ngan_hang
{
    public partial class Them_NV : DevExpress.XtraEditors.XtraForm
    {
        string TENTK = "", HOTENNV = "", MATKHAU = "", CHUCVU = ""/*, PHONGBAN = ""*/;
        public bool Islogin { get; set; }
        public Them_NV()
        {
            InitializeComponent();
        }
        public Them_NV(string TENTK, string HOTENNV, string MATKHAU, string CHUCVU/*, string PHONGBAN*/)
        {
            InitializeComponent();
            this.TENTK = TENTK;
            this.HOTENNV = HOTENNV;
            this.MATKHAU = MATKHAU;
            this.CHUCVU = CHUCVU;
            //this.PHONGBAN = PHONGBAN;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            List<NHANVIEN> listnhanhvien = context.NHANVIENs.ToList();
            List<CHINHANH> listchinhanh = context.CHINHANHs.ToList();
            List<PHONGBAN> listphongban = context.PHONGBANs.ToList();
            PhongbanchinhanhCombobox(listchinhanh);
            PBCombobox(listphongban);
            BindGrid(listnhanhvien);

        }
        private void bntThem_Click(object sender, EventArgs e)
        {
            //Islogin = true;
            //if (CHUCVU == "Trưởng Phòng" /*|| CHUCVU == "Phó Phòng"*/ /*&& PHONGBAN == "Phòng Nhân sự"*/)
            //{
                string gioitinh;
                if (radNAM.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                try
                {
                    if (txtMANV.Text.Trim() == "" || txtTEN.Text.Trim() == "" || txtCHUCVU.Text.Trim() == "" || txtLUONG.Text.Trim() == "")
                    {

                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    int a = dgvNhanvien.Rows.Add();
                    NHANVIEN nv = new NHANVIEN();
                    nv.MANV = txtMANV.Text;
                    nv.HOTENNV = txtTEN.Text;
                    nv.NGAYSINH = dtpNGAYSINH.Value;
                    nv.GIOITINH = gioitinh;
                    nv.TENTK = txt_tendangnhap.Text;
                    byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txt_matkhau.Text.ToString());
                
                    nv.MATKHAU = Hash(passtohash);
                    nv.CHUCVU = txtCHUCVU.Text;
                    nv.LUONGCB = txtLUONG.Text;
                    nv.MAPHONGBAN = string.Format(cboPHONGBAN.SelectedValue.ToString());
                    nv.MACHINHANH = string.Format(cboCHINHANH.SelectedValue.ToString());
                    DBcontext context = new DBcontext();
                    NHANVIEN finDB = context.NHANVIENs.FirstOrDefault(p => p.MANV == nv.MANV);
                    if (finDB == null)
                    {
                        context.NHANVIENs.Add(nv);
                        context.SaveChanges();
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
            string cl = "Vừa mới:" + bntThem.Text + " " + "nhân viên: "+txtTEN.Text;
            Dang_Nhap_Nhan_Vien n = new Dang_Nhap_Nhan_Vien();
            n.h();
            string tnd = "" + n.h();
            t.TENTK = tnd;
            t.NOIDUNG = cl;
            t.THOIGIAN = thoigian;

            context1.CHECKLOGs.Add(t);
            context1.SaveChanges();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không đủ quyền sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            //}

        }

        private void Them_NV_Load(object sender, EventArgs e)
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

        private void txtCHUCVU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLUONG_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public String Hash(byte[] val)// code ma hoa SHA_1
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }
        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            //String mahoa = "";
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txt_matkhau.Text.ToString());
           
            //mahoa = Hash(passtohash);
            //return mahoa; 
        }

        private void radNAM_CheckedChanged(object sender, EventArgs e)
        {

        }

        /* private String txtMahoa (String s)
{




    return s;

}*/
        private void PhongbanchinhanhCombobox(List<CHINHANH> listchinhanh)
        {
            this.cboCHINHANH.DataSource = listchinhanh;
            this.cboCHINHANH.DisplayMember = "TENCHINHANH";
            this.cboCHINHANH.ValueMember = "MACHINHANH";
            //this.cboPHONGBAN.DataSource = listphongban;
            //this.cboPHONGBAN.DisplayMember = "TENPHONGBAN";
            //this.cboPHONGBAN.ValueMember = "MAPHONGBAN";
        }
        private void PBCombobox(List<PHONGBAN> listphongban)
        {
            //this.cboCHINHANH.DataSource = listchinhanh;
            //this.cboCHINHANH.DisplayMember = "TENCHINHANH";
            //this.cboCHINHANH.ValueMember = "MACHINHANH";
            this.cboPHONGBAN.DataSource = listphongban;
            this.cboPHONGBAN.DisplayMember = "TENPB";
            this.cboPHONGBAN.ValueMember = "MAPHONGBAN";
        }
        private void cboPHONGBAN_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }
    }
}