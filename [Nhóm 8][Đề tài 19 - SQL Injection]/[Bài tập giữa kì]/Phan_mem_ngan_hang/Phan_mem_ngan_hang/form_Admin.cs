using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Phan_mem_ngan_hang
{
    public partial class form_Admin : DevExpress.XtraEditors.XtraUserControl
    {
        private static form_Admin _admin;
        public static form_Admin admin1
        {
            get
            {
                if (_admin == null)
                {
                    _admin = new form_Admin();

                }
                return _admin;

            }
        }
       
        public form_Admin()
        {
            InitializeComponent();
        }

        private void form_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_giamsat_Click(object sender, EventArgs e)
        {
            Form_giamsatcuaadmin giamsat = new Form_giamsatcuaadmin();
            giamsat.ShowDialog();
            //loadData();
        }
    }
}
