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
    public partial class frmchatlieu : DevExpress.XtraEditors.XtraForm
    {
        public frmchatlieu()
        {
            InitializeComponent();
        }

        private void frmchatlieu_Load(object sender, EventArgs e)
        {
            Model2 context = new Model2();
            List<CHATLIEU> listchatlieu  = context.CHATLIEUx.ToList();
            LoadDataGridView(listchatlieu);
        }
        private void LoadDataGridView(List<CHATLIEU> listchatlieu)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listchatlieu)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MACHATLIEU;
                dataGridView1.Rows[index].Cells[1].Value = item.TENCHATLIEU;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows.Count;
            for (int i = 0; i < n; i++)
            {

                txtmacl.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txttencl.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Model2 context = new Model2();
                    List<CHATLIEU> listchatlieu = context.CHATLIEUx.ToList();
                    if (txtmacl.Text.Trim() == "" || txttencl.Text.Trim() == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    CHATLIEU n = new CHATLIEU();
                    n.MACHATLIEU = txtmacl.Text;
                    n.TENCHATLIEU = txttencl.Text;
                    CHATLIEU finfdb = context.CHATLIEUx.FirstOrDefault(p => p.MACHATLIEU == n.TENCHATLIEU);
                    if (finfdb == null)
                    {
                        context.CHATLIEUx.Add(n);
                        context.SaveChanges();
                    }

                    LoadDataGridView(context.CHATLIEUx.ToList());
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
            List<CHATLIEU> listchatlieu = context.CHATLIEUx.ToList();

            CHATLIEU n = new CHATLIEU();
            n.MACHATLIEU = txtmacl.Text;
            n.TENCHATLIEU = txttencl.Text;
            CHATLIEU finfdb = context.CHATLIEUx.FirstOrDefault(p => p.MACHATLIEU == n.TENCHATLIEU);


            DialogResult dialogResult = MessageBox.Show("Ban co chac muon xoa ko?", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (finfdb != null)
                {
                    context.CHATLIEUx.Remove(finfdb);
                    context.SaveChanges();
                    MessageBox.Show("Xoa thanh cong");
                }

            }

            LoadDataGridView(context.CHATLIEUx.ToList());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                Model2 context = new Model2();
                List<CHATLIEU> listnhanvien = context.CHATLIEUx.ToList();
                if (txtmacl.Text.Trim() == "" || txttencl.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                CHATLIEU n = new CHATLIEU();
                n.MACHATLIEU = txtmacl.Text;
                n.TENCHATLIEU = txttencl.Text;
                CHATLIEU finfdb = context.CHATLIEUx.FirstOrDefault(p => p.MACHATLIEU == n.TENCHATLIEU);
                if (finfdb != null)
                    if (finfdb != null)
                {
                    finfdb.MACHATLIEU = n.MACHATLIEU;
                    finfdb.TENCHATLIEU = n.TENCHATLIEU;
                    context.SaveChanges();
                    MessageBox.Show("Cap nhat thanh cong");
                }
                LoadDataGridView(context.CHATLIEUx.ToList());

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