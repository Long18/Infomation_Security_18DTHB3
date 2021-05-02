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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void loadListOfStaffs()
        {
            dgvStaffList.DataSource = StaffDAO.Instance.getStaffsList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string tel = txtTel.Text.Trim();
            string address = txtAddress.Text.Trim();
            string unitSalary = txtUnitSalary.Text.Trim();

            if (!checkData(name, tel, address, unitSalary)) return;

            if (StaffDAO.Instance.insertStaff(name, tel, address, unitSalary))
            {
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfStaffs();
                lblNotify.Text = "Đã thêm nhân viên vào CSDL";
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool checkData(string name, string tel, string address, string unitSalary)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(unitSalary))
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            loadListOfStaffs();
        }

        private void dgvStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvStaffList.CurrentRow.Index;
            txtName.Text = dgvStaffList.Rows[index].Cells[1].Value.ToString();
            txtTel.Text = dgvStaffList.Rows[index].Cells[2].Value.ToString();
            txtAddress.Text = dgvStaffList.Rows[index].Cells[3].Value.ToString();
            txtUnitSalary.Text = dgvStaffList.Rows[index].Cells[4].Value.ToString();
            lblNotify.Text = "Đã chọn 1 nhân viên";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvStaffList.Rows[dgvStaffList.CurrentRow.Index].Cells[0].Value.ToString();
            if (StaffDAO.Instance.deleteStaff(id))
            {
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfStaffs();
                lblNotify.Text = "Đã xóa nhân viên khỏi CSDL";
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.Clear();
            txtTel.Clear();
            txtAddress.Clear();
            txtUnitSalary.Clear();
            for (int i = 0; i < dgvStaffList.RowCount; i++)
                dgvStaffList.Rows[i].Selected = false;
            lblNotify.Text = "Nhập thông tin nước uống để thêm vào CSDL";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string tel = txtTel.Text.Trim();
            string address = txtAddress.Text.Trim();
            string unitSalary = txtUnitSalary.Text.Trim();
            string id = dgvStaffList.Rows[dgvStaffList.CurrentRow.Index].Cells[0].Value.ToString();

            if (!checkData(name, tel, address, unitSalary)) return;

            if (StaffDAO.Instance.updateStaff(id, name, tel, address, unitSalary))
            {
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfStaffs();
                lblNotify.Text = "Đã cập nhật thông tin nhân viên vào CSDL";
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
