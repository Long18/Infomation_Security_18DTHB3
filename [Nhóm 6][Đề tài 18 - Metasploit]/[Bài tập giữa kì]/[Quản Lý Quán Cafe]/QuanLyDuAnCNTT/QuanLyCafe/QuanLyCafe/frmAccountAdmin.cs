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
    public partial class frmAccountAdmin : Form
    {
        public frmAccountAdmin()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtPassword.Clear();
            txtUsername.Clear();
            for (int i = 0; i < dgvAdminList.RowCount; i++)
                dgvAdminList.Rows[i].Selected = false;
            lblNotify.Text = "Nhập thông tin tài khoản để thêm vào CSDL";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string id = dgvAdminList.Rows[dgvAdminList.CurrentRow.Index].Cells[0].Value.ToString();

            if (!checkData(username, password)) return;

            if (AccountAdminDAO.Instance.updateAccountAmin(id, username, password))
            {
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfAccountAdmins();
                lblNotify.Text = "Đã cập nhật tài khoản quản trị vào CSDL";
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool checkData(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void loadListOfAccountAdmins()
        {
            dgvAdminList.DataSource = AccountAdminDAO.Instance.getAccountAdminsList();
        }

        private void frmAccountAdmin_Load(object sender, EventArgs e)
        {
            loadListOfAccountAdmins();
        }

        private void dgvAdminList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvAdminList.CurrentRow.Index;
            txtUsername.Text = dgvAdminList.Rows[index].Cells[1].Value.ToString();
            lblNotify.Text = "Đã chọn 1 tài khoản";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!checkData(username, password)) return;

            if (AccountAdminDAO.Instance.insertAccountAdmin(username, password))
            {
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfAccountAdmins();
                lblNotify.Text = "Đã thêm 1 tài khoản admin vào CSDL";
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvAdminList.Rows[dgvAdminList.CurrentRow.Index].Cells[0].Value.ToString();
            if (AccountAdminDAO.Instance.deleteAccountAmin(id))
            {
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfAccountAdmins();
                lblNotify.Text = "Đã xóa tài khoản khỏi CSDL";
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
