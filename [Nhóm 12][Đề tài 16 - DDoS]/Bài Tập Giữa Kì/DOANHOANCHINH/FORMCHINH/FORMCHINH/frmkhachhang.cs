using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMCHINH
{
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
        }
        private void LoadDataGridView(List<KHACHHANG> listkhachhang)
        {
            dgvkhachhang.Rows.Clear();
            foreach (var item in listkhachhang)
            {
                int index = dgvkhachhang.Rows.Add();
                dgvkhachhang.Rows[index].Cells[0].Value = item.MAKHACH;
                dgvkhachhang.Rows[index].Cells[1].Value = item.TENKHACH;
                dgvkhachhang.Rows[index].Cells[2].Value = item.DIACHI;
                dgvkhachhang.Rows[index].Cells[3].Value = item.DIENTHOAI;
            }
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            Model2 context = new Model2();
            List<KHACHHANG> listkhachhang = context.KHACHHANGs.ToList();
            LoadDataGridView(listkhachhang);
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvkhachhang.SelectedRows.Count;
            for (int i = 0; i < n; i++)
            {

                txtmakhach.Text = dgvkhachhang.SelectedRows[0].Cells[0].Value.ToString();
                txttenkhach.Text = dgvkhachhang.SelectedRows[0].Cells[1].Value.ToString();
                txtdiachikhach.Text = dgvkhachhang.SelectedRows[0].Cells[2].Value.ToString();
                txtdienthoaikhach.Text = dgvkhachhang.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Model2 context = new Model2();
                    List<KHACHHANG> listnhanvien = context.KHACHHANGs.ToList();
                    if (txtmakhach.Text.Trim() == "" || txttenkhach.Text.Trim() == "" || txtdiachikhach.Text.Trim() == "" || txtdienthoaikhach.Text.Trim() == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    KHACHHANG n = new KHACHHANG();
                    n.MAKHACH = txtmakhach.Text;
                    n.TENKHACH = txttenkhach.Text;
                    n.DIACHI = txtdiachikhach.Text;
                    n.DIENTHOAI = txtdienthoaikhach.Text;

                    KHACHHANG finfdb = context.KHACHHANGs.FirstOrDefault(p => p.MAKHACH == n.MAKHACH);
                    if (finfdb == null)
                    {
                        context.KHACHHANGs.Add(n);
                        context.SaveChanges();
                    }

                    LoadDataGridView(context.KHACHHANGs.ToList());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Model2 context = new Model2();
            List<KHACHHANG> listTacgia = context.KHACHHANGs.ToList();

            KHACHHANG n = new KHACHHANG();
            n.MAKHACH = txtmakhach.Text;
            n.TENKHACH = txttenkhach.Text;
            n.DIACHI = txtdiachikhach.Text;
            n.DIENTHOAI = txtdienthoaikhach.Text;
            KHACHHANG finfdb = context.KHACHHANGs.FirstOrDefault(p => p.MAKHACH == n.MAKHACH);
            DialogResult dialogResult = MessageBox.Show("Ban co chac muon xoa ko?", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (finfdb != null)
                {
                    context.KHACHHANGs.Remove(finfdb);
                    context.SaveChanges();
                    MessageBox.Show("Xoa thanh cong");
                }
            }
            LoadDataGridView(context.KHACHHANGs.ToList());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                Model2 context = new Model2();
                List<KHACHHANG> listnhanvien = context.KHACHHANGs.ToList();
                if (txtmakhach.Text.Trim() == "" || txttenkhach.Text.Trim() == "" || txtdiachikhach.Text.Trim() == "" || txtdienthoaikhach.Text.Trim() == "")
                {
                    throw new Exception("Vui long nhap day du thong tin");
                }
                KHACHHANG n = new KHACHHANG();
                n.MAKHACH = txtmakhach.Text;
                n.TENKHACH = txttenkhach.Text;
                n.DIACHI = txtdiachikhach.Text;
                n.DIENTHOAI = txtdienthoaikhach.Text;
                KHACHHANG finfdb = context.KHACHHANGs.FirstOrDefault(p => p.MAKHACH == n.MAKHACH);
                if (finfdb != null)
                {
                    finfdb.MAKHACH = n.MAKHACH;
                    finfdb.TENKHACH = n.TENKHACH;
                    finfdb.DIACHI = n.DIACHI;
                    finfdb.DIENTHOAI = n.DIENTHOAI;
                    MessageBox.Show("Cap nhat thanh cong");
                }
                LoadDataGridView(context.KHACHHANGs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
