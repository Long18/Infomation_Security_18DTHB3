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
    public partial class frmhanghoa : Form
    {
        public frmhanghoa()
        {
            InitializeComponent();
        }
        private void LoadDataGridView(List<HANGHOA> listhanghoa)
        {
            dgvhanghoa.Rows.Clear();
            foreach (var item in listhanghoa)
            {
                int index = dgvhanghoa.Rows.Add();
                dgvhanghoa.Rows[index].Cells[0].Value = item.MAHANG;
                dgvhanghoa.Rows[index].Cells[1].Value = item.TENHANG;
                dgvhanghoa.Rows[index].Cells[2].Value = item.CHATLIEU.TENCHATLIEU;
                dgvhanghoa.Rows[index].Cells[3].Value = item.SOLUONG;
                dgvhanghoa.Rows[index].Cells[4].Value = item.DONGIA;
                
            }
        }
        private void loadchatlieu(List<CHATLIEU> listchatlieu)
        {
            this.cboChatlieu.DataSource = listchatlieu;
            this.cboChatlieu.DisplayMember = "TENCHATLIEU";
            this.cboChatlieu.ValueMember = "MACHATLIEU";
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvhanghoa.SelectedRows.Count;
            for (int i = 0; i < n; i++)
            {

                txtmahang.Text = dgvhanghoa.SelectedRows[0].Cells[0].Value.ToString();
                txttenhang.Text = dgvhanghoa.SelectedRows[0].Cells[1].Value.ToString();
                cboChatlieu.Text = dgvhanghoa.SelectedRows[0].Cells[2].Value.ToString();
                txtsoluong.Text = dgvhanghoa.SelectedRows[0].Cells[3].Value.ToString();
                txtdongia.Text = dgvhanghoa.SelectedRows[0].Cells[4].Value.ToString();
           
                            
            }
        }

        private void frmhanghoa_Load(object sender, EventArgs e)
        {
            Model2 context = new Model2();
            List<HANGHOA> listhanghoa = context.HANGHOAs.ToList();
            List<CHATLIEU> listchatlieu = context.CHATLIEUx.ToList();
            LoadDataGridView(listhanghoa);
            loadchatlieu(listchatlieu);
        }
        

        private void btnthem_Click(object sender, EventArgs e)
        {
            {
                Model2 context = new Model2();
                try
                {
                   
                    if (txtmahang.Text.Trim() == "" || txttenhang.Text.Trim() == "" || cboChatlieu.Text.Trim() == "" || txtsoluong.Text.Trim() == "" || txtdongia.Text.Trim() == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    HANGHOA n = new HANGHOA();
                    n.MAHANG = txtmahang.Text;
                    n.TENHANG = txttenhang.Text;
                    n.MACHATLIEU = cboChatlieu.SelectedValue.ToString();
                    n.SOLUONG = int.Parse(txtsoluong.Text);
                    n.DONGIA = int.Parse(txtdongia.Text);
                    HANGHOA finfdb = context.HANGHOAs.FirstOrDefault(p => p.MAHANG == n.TENHANG);
                    if (finfdb == null)
                    {
                        context.HANGHOAs.Add(n);
                        context.SaveChanges();
                        MessageBox.Show("Thêm mới thành công");
                    }

                    LoadDataGridView(context.HANGHOAs.ToList());
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
            List<HANGHOA> listTacgia = context.HANGHOAs.ToList();

            HANGHOA n = new HANGHOA();
            n.MAHANG = txtmahang.Text;
            n.TENHANG = txttenhang.Text;
            n.MACHATLIEU = cboChatlieu.SelectedValue.ToString();
            n.SOLUONG = int.Parse(txtsoluong.Text);
            n.DONGIA = int.Parse(txtdongia.Text);
           

            HANGHOA finfdb = context.HANGHOAs.FirstOrDefault(p => p.MAHANG == n.MAHANG);
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (finfdb != null)
                {
                    context.HANGHOAs.Remove(finfdb);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                }
            }
            LoadDataGridView(context.HANGHOAs.ToList());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                Model2 context = new Model2();
                List<HANGHOA> listnhanvien = context.HANGHOAs.ToList();
                if (txtmahang.Text.Trim() == "" || txttenhang.Text.Trim() == "" || cboChatlieu.Text.Trim() == "" || txtsoluong.Text.Trim() == "" || txtdongia.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                HANGHOA n = new HANGHOA();
                n.MAHANG = txtmahang.Text;
                n.TENHANG = txttenhang.Text;
                n.MACHATLIEU = cboChatlieu.SelectedValue.ToString();
                n.SOLUONG = int.Parse(txtsoluong.Text);
                n.DONGIA = int.Parse(txtdongia.Text);


                HANGHOA finfdb = context.HANGHOAs.FirstOrDefault(p => p.MAHANG == n.MAHANG);
                if (finfdb != null)
                {
                    finfdb.MAHANG = n.MAHANG;
                    finfdb.TENHANG = n.TENHANG;
                    finfdb.MACHATLIEU = n.MACHATLIEU;
                    finfdb.SOLUONG = n.SOLUONG;
                    finfdb.DONGIA = n.DONGIA;
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                }
                LoadDataGridView(context.HANGHOAs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboChatlieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
