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
    public partial class DsKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        private static DsKhachHang _dskhachhang;
        public static DsKhachHang dskhachhang
        {
            get
            {
                if (_dskhachhang == null)
                {
                    _dskhachhang = new DsKhachHang();
                }
                return _dskhachhang;
            }
        }
        public DsKhachHang()
        {
            InitializeComponent();
        }
        private void BindGrid(List<KHACHHANG> listkhachhang)
        {
            dgvKhachhang.Rows.Clear();
            foreach (var item in listkhachhang)
            {
                int a = dgvKhachhang.Rows.Add();
                dgvKhachhang.Rows[a].Cells[0].Value = item.MAKH;
                dgvKhachhang.Rows[a].Cells[1].Value = item.HOTEN;
                dgvKhachhang.Rows[a].Cells[2].Value = item.NGAYSINH;
                dgvKhachhang.Rows[a].Cells[3].Value = item.GIOITINH;
                dgvKhachhang.Rows[a].Cells[4].Value = item.SOCMND;
                dgvKhachhang.Rows[a].Cells[5].Value = item.DIACHI;
                dgvKhachhang.Rows[a].Cells[6].Value = item.HOKHAU;
                dgvKhachhang.Rows[a].Cells[7].Value = item.SDT;
            }
        }
        private void loadData()
        {

            DBcontext context = new DBcontext();
            List<KHACHHANG> listkhachhang = context.KHACHHANGs.ToList();
            BindGrid(listkhachhang);

        }
        private void DsKhachHang_Load(object sender, EventArgs e)
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

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            btn_Themkhachhang themkh = new btn_Themkhachhang();
            themkh.ShowDialog();
            loadData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_TimKiem timkiem = new btn_TimKiem();
            timkiem.ShowDialog();
            loadData();
        }
    }
}
