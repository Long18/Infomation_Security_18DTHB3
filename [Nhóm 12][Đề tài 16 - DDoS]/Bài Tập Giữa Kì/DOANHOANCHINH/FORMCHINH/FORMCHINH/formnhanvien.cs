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
    public partial class formnhanvien : DevExpress.XtraEditors.XtraForm
    {
        public formnhanvien()
        {
            InitializeComponent();
        }
        private void LoadDataGridView(List<NHANVIEN> listnhanvien)
        {
            dgvnhanvien.Rows.Clear();
            foreach (var item in listnhanvien)
            {
                int index = dgvnhanvien.Rows.Add();
                dgvnhanvien.Rows[index].Cells[0].Value = item.MANHANVIEN;
                dgvnhanvien.Rows[index].Cells[1].Value = item.TENNHANVIEN;
                dgvnhanvien.Rows[index].Cells[2].Value = item.GIOITINH;
                dgvnhanvien.Rows[index].Cells[3].Value = item.NGAYSINH;
                dgvnhanvien.Rows[index].Cells[4].Value = item.DIACHI;
                dgvnhanvien.Rows[index].Cells[5].Value = item.DIENTHOAI;

            }
        }
        private void formnhanvien_Load(object sender, EventArgs e)
        {

            Model2 context = new Model2();
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            LoadDataGridView(listnhanvien);
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvnhanvien.SelectedRows.Count;
            for (int i = 0; i < n; i++)
            {

                txtmanv.Text = dgvnhanvien.SelectedRows[0].Cells[0].Value.ToString();
                txttennv.Text = dgvnhanvien.SelectedRows[0].Cells[1].Value.ToString();
                if (dgvnhanvien.Rows[i].Cells[3].Value.ToString() == "Nam")
                {
                    radnam.Checked = true;
                }
                else
                {
                    radnu.Checked = true;
                    dtpngaysinh.Text = dgvnhanvien.SelectedRows[0].Cells[3].Value.ToString();
                    txtdiachi.Text = dgvnhanvien.SelectedRows[0].Cells[4].Value.ToString();
                    txtdienthoai.Text = dgvnhanvien.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Model2 context = new Model2();
                    List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
                    if (txtmanv.Text.Trim() == "" || txttennv.Text.Trim() == "" || radnam.Text.Trim() == "" || radnu.Text.Trim() == "" || dtpngaysinh.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtdienthoai.Text.Trim() == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    NHANVIEN n = new NHANVIEN();
                    n.MANHANVIEN = txtmanv.Text;
                    n.TENNHANVIEN = txttennv.Text;
                    n.GIOITINH = radnam.Checked ? "Nam" : "Nữ";
                    n.NGAYSINH = dtpngaysinh.Value;
                    n.DIACHI = txtdiachi.Text;
                    n.DIENTHOAI = txtdienthoai.Text;

                    NHANVIEN finfdb = context.NHANVIENs.FirstOrDefault(p => p.MANHANVIEN == n.MANHANVIEN);
                    if (finfdb == null)
                    {
                        context.NHANVIENs.Add(n);
                        context.SaveChanges();
                        MessageBox.Show("Thêm mới thành công");
                    }

                    LoadDataGridView(context.NHANVIENs.ToList());
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
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();

            NHANVIEN n = new NHANVIEN();
            n.MANHANVIEN = txtmanv.Text;
            n.TENNHANVIEN = txttennv.Text;
            n.GIOITINH = radnam.Checked ? "Nam" : "Nữ";
            n.NGAYSINH = dtpngaysinh.Value;
            n.DIACHI = txtdiachi.Text;
            n.DIENTHOAI = txtdienthoai.Text;


            NHANVIEN finfdb = context.NHANVIENs.FirstOrDefault(p => p.MANHANVIEN == n.MANHANVIEN);


            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (finfdb != null)
                {
                    context.NHANVIENs.Remove(finfdb);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                }

            }

            LoadDataGridView(context.NHANVIENs.ToList());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                Model2 context = new Model2();
                List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
                if (txtmanv.Text.Trim() == "" || txttennv.Text.Trim() == "" || radnam.Text.Trim() == "" || radnu.Text.Trim() == "" || dtpngaysinh.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtdienthoai.Text.Trim() == "")
                {
                    throw new Exception("Vui long nhap day du thong tin");
                }
                NHANVIEN n = new NHANVIEN();
                n.MANHANVIEN = txtmanv.Text;
                n.TENNHANVIEN = txttennv.Text;
                n.GIOITINH = radnam.Checked ? "Nam" : "Nữ";
                n.NGAYSINH = dtpngaysinh.Value;
                n.DIACHI = txtdiachi.Text;
                n.DIENTHOAI = txtdienthoai.Text;


                NHANVIEN finfdb = context.NHANVIENs.FirstOrDefault(p => p.MANHANVIEN == n.MANHANVIEN);
                if (finfdb != null)
                {
                    finfdb.MANHANVIEN = n.MANHANVIEN;
                    finfdb.TENNHANVIEN = n.TENNHANVIEN;
                    finfdb.GIOITINH = n.GIOITINH;
                    finfdb.NGAYSINH = n.NGAYSINH;
                    finfdb.DIACHI = n.DIACHI;
                    finfdb.DIENTHOAI = n.DIENTHOAI;

                    context.SaveChanges();
                    MessageBox.Show("Cap nhat thanh cong");
                }
                LoadDataGridView(context.NHANVIENs.ToList());

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