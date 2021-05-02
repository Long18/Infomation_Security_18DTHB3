using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DAO;

namespace QuanLyCafe
{
    public partial class frmDrink : Form
    {
        public frmDrink()
        {
            InitializeComponent();
        }

        private void frmDrink_Load(object sender, EventArgs e)
        {
            loadListOfDrinks();
        }

        private void loadListOfDrinks()
        {
            dgvDrinkList.DataSource = DrinkDAO.Instance.getDinksList();
        }

        private void dgvDrinkList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index= dgvDrinkList.CurrentRow.Index;
            txtNameOfDrink.Text = dgvDrinkList.Rows[index].Cells[1].Value.ToString();
            txtUnitPrice.Text = dgvDrinkList.Rows[index].Cells[2].Value.ToString();
            lblNotify.Text = "Đã chọn 1 thức uống";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvDrinkList.Rows[dgvDrinkList.CurrentRow.Index].Cells[0].Value.ToString();
            if (DrinkDAO.Instance.deleteDrink(id))
            {
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfDrinks();
                lblNotify.Text = "Đã xóa thức uống khỏi CSDL";
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nameOfDrink = txtNameOfDrink.Text.Trim();
            string unitPrice= txtUnitPrice.Text.Trim();

            if (!checkData(nameOfDrink, unitPrice)) return;

            if (DrinkDAO.Instance.insertDrink(nameOfDrink, unitPrice))
            {
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfDrinks();
                lblNotify.Text = "Đã thêm thức uống vào CSDL";
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool checkData(string nameOfDrink, string unitPrice)
        {
            if (string.IsNullOrEmpty(nameOfDrink) || string.IsNullOrEmpty(unitPrice))
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nameOfDrink = txtNameOfDrink.Text.Trim();
            string unitPrice = txtUnitPrice.Text.Trim();
            string id = dgvDrinkList.Rows[dgvDrinkList.CurrentRow.Index].Cells[0].Value.ToString();

            if (!checkData(nameOfDrink, unitPrice)) return;

            if (DrinkDAO.Instance.updateDrink(id, nameOfDrink, unitPrice))
            {
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfDrinks();
                lblNotify.Text = "Đã cập nhật thức uống vào CSDL";
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtNameOfDrink.Focus();
            txtNameOfDrink.Clear();
            txtUnitPrice.Clear();
            for (int i = 0; i < dgvDrinkList.RowCount; i++)
                dgvDrinkList.Rows[i].Selected = false;
            lblNotify.Text = "Nhập thông tin nước uống để thêm vào CSDL";
        }
    }
}
