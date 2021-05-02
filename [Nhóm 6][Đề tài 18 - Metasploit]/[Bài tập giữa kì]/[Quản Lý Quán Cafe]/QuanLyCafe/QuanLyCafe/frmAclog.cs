using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frmAclog : Form
    {
        public frmAclog()
        {
            InitializeComponent();
        }


        private void loadListOfActivity()
        {
            dgvActivitylist.DataSource = ActivityLogDAO.Instance.getActivityLog();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            loadListOfActivity();
        }


      /*  private void dgvActivitylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int index = dgvActivitylist.CurrentRow.Index;
            txtUserID.Text = dgvActivitylist.Rows[index].Cells[1].Value.ToString();
            txtName.Text = dgvActivitylist.Rows[index].Cells[1].Value.ToString();
            txtTel.Text = dgvActivitylist.Rows[index].Cells[2].Value.ToString();
            txtAddress.Text = dgvActivitylist.Rows[index].Cells[3].Value.ToString();
            txtUnitSalary.Text = dgvActivitylist.Rows[index].Cells[4].Value.ToString();
            lblNotify.Text = "Đã chọn 1 nhân viên";
        }

        */

    }
}
