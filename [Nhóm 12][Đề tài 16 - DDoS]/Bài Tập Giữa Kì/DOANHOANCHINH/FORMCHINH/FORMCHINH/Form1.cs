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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            formnhanvien f = new formnhanvien();
            f.Show();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            frmkhachhang f = new frmkhachhang();
            f.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            formnhanvien f = new formnhanvien();
        }

        private void mnuHanghoa_Click(object sender, EventArgs e)
        {
            frmhanghoa f = new frmhanghoa();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* mnuDanhmuc.Enabled = false;
            mnuHoadon.Enabled = false;
            mnuTimkiem.Enabled = false;*/
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchatlieu f = new frmchatlieu();
            f.Show();
        }

        private void mnuHoadonban_Click(object sender, EventArgs e)
        {
            frmhoadon f = new frmhoadon();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void mnudangnhap_Click(object sender, EventArgs e)
        {
            thongtintaikhoan t = new thongtintaikhoan();
            t.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdk f = new frmdk();
            f.Show();
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model23 t = new Model23();
            lichsu n = new lichsu();
            n.ShowDialog();
            
        }
   
        private void mnuFile_Click(object sender, EventArgs e)
        {
         
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdangnhap f = new frmdangnhap();
            Close();
        }
    }
}
