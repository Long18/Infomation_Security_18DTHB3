using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DAO;
using QuanLyCafe.DTO;

namespace QuanLyCafe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfo frm = new frmInfo();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadDrinksListToComboBox();
        }

        private void loadDrinksListToComboBox()
        {
            cboNameOfDrink.DisplayMember = "TENTHUCUONG";
            cboNameOfDrink.ValueMember = "ID";
            cboNameOfDrink.DataSource = DrinkDAO.Instance.getDinksList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int idOfDrink = Int32.Parse(cboNameOfDrink.SelectedValue.ToString());
            string nameOfDrink = DrinkDAO.Instance.getDink(idOfDrink).getNameOfDrink();
            int priceOfDrink = DrinkDAO.Instance.getDink(idOfDrink).getUnitPrice();
            int numberOfDrink = (int) numUpDownNumOfDrink.Value;
            dgvDrinkOrder.Rows.Add(new object[] {idOfDrink, nameOfDrink, numberOfDrink, priceOfDrink});

            calTotalPrice();
            lblNotify.Text = "Bạn đã thêm thức uống thành công";
        }

        private void calTotalPrice()
        {
            int res = 0;
            for (int row = 0; row < dgvDrinkOrder.Rows.Count; row++)
            {
                res += Int32.Parse(dgvDrinkOrder.Rows[row].Cells[2].Value.ToString()) * Int32.Parse(dgvDrinkOrder.Rows[row].Cells[3].Value.ToString());
            }
            txtTotalPrice.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDrinkOrder.CurrentRow.Index;
                dgvDrinkOrder.Rows.RemoveAt(index);
                lblNotify.Text = "Đã xóa thức uống thành công";
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy chọn thức uống trong bảng hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            calTotalPrice();
        }

        private void dgvDrinkOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (numUpDownNumOfDrink.DataBindings.Count > 0)
            {
                numUpDownNumOfDrink.DataBindings.RemoveAt(0);
            }
            numUpDownNumOfDrink.DataBindings.Add(new Binding("Text", dgvDrinkOrder[2, e.RowIndex], "value", false));
            lblNotify.Text = "Đang chọn 1 thức uống";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDrinkOrder.RowCount; i++)
                dgvDrinkOrder.Rows[i].Selected = false;
            calTotalPrice();

            lblNotify.Text = "Cập nhật thành công";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvDrinkOrder.Rows.Clear();
            calTotalPrice();
            lblNotify.Text = "Vui lòng chọn thức uống từ combo box và nhập số lượng để thêm vào hóa đơn";
            btnPay.Enabled = true;
        }

        private void thứcUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrink frm = new frmDrink();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            loadDrinksListToComboBox();
        }

        private void tàiKhoảnQuảnTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountAdmin frm = new frmAccountAdmin();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void chấmCôngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmWorkSchedule frm = new frmWorkSchedule();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void thốngKêLươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorkScheduleReport frm = new frmWorkScheduleReport();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvDrinkOrder.Rows.Count <= 0)
                return;
            try
            {
                BillDAO.Instance.insertNewEmptyBill().ToString();
                int idBill = BillDAO.Instance.getLatestBill();
                for (int row = 0; row < dgvDrinkOrder.Rows.Count; row++)
                {
                    string idDrink= dgvDrinkOrder.Rows[row].Cells[0].Value.ToString();
                    string numberOfDrink= dgvDrinkOrder.Rows[row].Cells[2].Value.ToString();
                    bool res= DrinkDAO.Instance.insertDrinkToBill(idBill.ToString(), idDrink, numberOfDrink);
                    if (!res) throw new System.Exception();
                }
                MessageBox.Show("Đã thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPay.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.getLatestBill();
            frmBillReport frm = new frmBillReport(Convert.ToString(idBill));
            frm.ShowDialog();
        }

        private void báoCáoDanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncomeReport frm = new frmIncomeReport();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
