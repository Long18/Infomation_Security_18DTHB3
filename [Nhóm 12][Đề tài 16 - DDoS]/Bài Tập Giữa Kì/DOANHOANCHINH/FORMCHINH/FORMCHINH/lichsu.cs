﻿using System;
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
    public partial class lichsu : Form
    {
        public lichsu()
        {
            InitializeComponent();
        }

        private void lichsu_Load(object sender, EventArgs e)
        {
            Model23 t = new Model23();
            checklog v = new checklog();
            dataGridView1.DataSource = t.checklogs.ToList();
            
        }
    }
}
