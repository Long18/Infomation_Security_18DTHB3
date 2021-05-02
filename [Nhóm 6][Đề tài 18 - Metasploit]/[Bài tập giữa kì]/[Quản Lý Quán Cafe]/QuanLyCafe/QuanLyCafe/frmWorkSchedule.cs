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
    public partial class frmWorkSchedule : Form
    {
        public frmWorkSchedule()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void loadListOfDayWorks(string idStaff)
        {
            dgvDayWorksList.DataSource = DayWorkDAO.Instance.getDayWorkByIdStaff(idStaff);
        }

        private void loadStaffsListToComboBox()
        {
            cboStaff.DisplayMember = "HOTEN";
            cboStaff.ValueMember = "ID";
            cboStaff.DataSource = StaffDAO.Instance.getStaffsList();
        }

        private void frmWorkSchedule_Load(object sender, EventArgs e)
        {
            loadStaffsListToComboBox();
            loadListOfDayWorks(cboStaff.SelectedValue.ToString());
        }

        private void cboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadListOfDayWorks(cboStaff.SelectedValue.ToString());
        }

        private void btnUntick_Click_1(object sender, EventArgs e)
        {
            string id = dgvDayWorksList.Rows[dgvDayWorksList.CurrentRow.Index].Cells[0].Value.ToString();
            if (DayWorkDAO.Instance.deleteDayWork(id))
            {
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfDayWorks(cboStaff.SelectedValue.ToString());
                lblNotify.Text = "Đã xóa ngày làm khỏi CSDL";
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            string dayWork = dateTimePicker1.Value.ToShortDateString();
            string idStaff = cboStaff.SelectedValue.ToString();
            if (DayWorkDAO.Instance.insertDayWork(idStaff, dayWork))
            {
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListOfDayWorks(idStaff);
                lblNotify.Text = "Đã thêm ngày làm vào CSDL";
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
