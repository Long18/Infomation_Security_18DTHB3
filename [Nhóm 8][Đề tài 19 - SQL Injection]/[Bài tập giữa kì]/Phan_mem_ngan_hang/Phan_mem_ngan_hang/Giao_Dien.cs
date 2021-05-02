using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phan_mem_ngan_hang
{
    public partial class Giao_Dien : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        string TENTK = "", HOTEN = "", MATKHAU = "", PHONGBAN = "";
        public Giao_Dien()
        {
            InitializeComponent();
        }
        public Giao_Dien(string TENTK,string HOTEN,string MATKHAU, string PHONGBAN)
        {
            InitializeComponent();
            this.TENTK = TENTK;
            this.HOTEN = HOTEN;
            this.MATKHAU = MATKHAU;
            this.PHONGBAN = PHONGBAN;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            if(!Container1.Controls.Contains(Trangchu.trangchu))
            {
                Container1.Controls.Add(Trangchu.trangchu);
                Trangchu.trangchu.Dock = DockStyle.Fill;
                Trangchu.trangchu.BringToFront();
            }
            Trangchu.trangchu.BringToFront();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

        }
    }
}
