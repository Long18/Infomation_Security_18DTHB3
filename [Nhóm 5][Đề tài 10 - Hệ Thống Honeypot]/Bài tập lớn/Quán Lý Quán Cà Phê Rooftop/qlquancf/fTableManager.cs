﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlquancf
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.ShowDialog();
        }
    }
}
