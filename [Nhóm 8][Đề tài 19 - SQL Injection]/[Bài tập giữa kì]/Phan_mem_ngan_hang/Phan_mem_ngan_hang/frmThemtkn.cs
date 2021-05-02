using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_ngan_hang
{
    public partial class frmThemtkn : Form
    {
        public frmThemtkn()
        {
            InitializeComponent();
        }
        public string m()
        {

            return txtTknhan.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
