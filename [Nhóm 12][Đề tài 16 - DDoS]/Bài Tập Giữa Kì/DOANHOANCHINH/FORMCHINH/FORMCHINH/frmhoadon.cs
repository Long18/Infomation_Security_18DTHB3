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

namespace FORMCHINH
{
    public partial class frmhoadon : DevExpress.XtraEditors.XtraForm
    {
        public frmhoadon()
        {
            InitializeComponent();
        }
         private void LoadDataGridView(List<CHITIETHOADONBAN> listchitiet)
         {
             dgvhoadon.Rows.Clear();
             foreach (var item in listchitiet)
             {
                 int index = dgvhoadon.Rows.Add();
                 dgvhoadon.Rows[index].Cells[0].Value = item.MAHOADON;
                 dgvhoadon.Rows[index].Cells[1].Value = item.HOADONBAN.NGAYBAN;
                 dgvhoadon.Rows[index].Cells[2].Value = item.HOADONBAN.KHACHHANG.TENKHACH;
                 dgvhoadon.Rows[index].Cells[3].Value = item.HANGHOA.TENHANG;
                 dgvhoadon.Rows[index].Cells[4].Value = item.SOLUONG;
                 dgvhoadon.Rows[index].Cells[5].Value = item.DONGIA;
                 dgvhoadon.Rows[index].Cells[6].Value = item.THANHTIEN;
            }
         }
        private void loadhanghoa(List<HANGHOA> listhanghoa)
        {
            this.cbotenhang.DataSource = listhanghoa;
            this.cbotenhang.DisplayMember = "TENHANG";
            this.cbotenhang.ValueMember = "MAHANG";

        }
   
        private void loadkhach(List<KHACHHANG> listkhach)
        {
            this.cbotenkhach.DataSource = listkhach;
            this.cbotenkhach.DisplayMember = "TENKHACH";
            this.cbotenkhach.ValueMember = "MAKHACH";

        }
    
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            Model2 context = new Model2();
            List<CHITIETHOADONBAN> listchitiet = context.CHITIETHOADONBANs.ToList();
            List<HANGHOA> listhanghoa = context.HANGHOAs.ToList();
      
            List<KHACHHANG> listkhach = context.KHACHHANGs.ToList();
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            LoadDataGridView(listchitiet);
            loadhanghoa(listhanghoa);
   
            loadkhach(listkhach);

        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvhoadon.SelectedRows.Count;
            for (int i = 0; i < n; i++)
            {

                txtmahd.Text = dgvhoadon.SelectedRows[0].Cells[0].Value.ToString();
                dtpngayban.Text = dgvhoadon.SelectedRows[0].Cells[1].Value.ToString();
                cbotenkhach.Text = dgvhoadon.SelectedRows[0].Cells[2].Value.ToString();
                cbotenhang.Text = dgvhoadon.SelectedRows[0].Cells[3].Value.ToString();
                txtsoluong.Text = dgvhoadon.SelectedRows[0].Cells[4].Value.ToString();
                txtdongia.Text = dgvhoadon.SelectedRows[0].Cells[5].Value.ToString();
                txtthanhtien.Text = dgvhoadon.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            {
                Model2 context = new Model2();
                try
                {

                    if (txtmahd.Text.Trim() == "" || dtpngayban.Text.Trim() == "" || cbotenkhach.Text.Trim() == "" || cbotenhang.Text.Trim() == "" || txtsoluong.Text.Trim() == "" || txtdongia.Text.Trim() == "" || txtthanhtien.Text.Trim() == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    CHITIETHOADONBAN n = new CHITIETHOADONBAN();
                    n.HOADONBAN.MAHOADON = txtmahd.Text;
                    n.HOADONBAN.NGAYBAN= dtpngayban.Value;
                    n.HOADONBAN.MAKHACH = cbotenkhach.SelectedValue.ToString();
                    n.MAHANG = cbotenhang.SelectedValue.ToString();
                    n.SOLUONG = int.Parse(txtsoluong.Text);
                    n.DONGIA = int.Parse(txtdongia.Text);
                    n.THANHTIEN = int.Parse(txtthanhtien.Text);
                    CHITIETHOADONBAN finfdb = context.CHITIETHOADONBANs.FirstOrDefault(p => p.MAHOADON == n.MAHOADON);
                    if (finfdb == null)
                    {
                        context.CHITIETHOADONBANs.Add(n);
                        context.SaveChanges();
                        MessageBox.Show("Thêm mới thành công");
                    }

                    LoadDataGridView(context.CHITIETHOADONBANs.ToList());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}