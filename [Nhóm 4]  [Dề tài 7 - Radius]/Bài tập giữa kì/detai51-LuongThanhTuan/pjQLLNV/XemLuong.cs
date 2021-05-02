using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using pjQLLNV;

namespace pjQLLNV
{
    public partial class XemLuong : Form
    {
        Model1 db = new Model1();
        public XemLuong()
        {
            InitializeComponent();
        }

        private void XemLuong_Load(object sender, EventArgs e)
        {

            LoadNV();
        }
        private void LoadNV()
        {
                      var lstTL = db.BANGLUONGs
                 .Join(db.NHANVIENs,
                     bl => bl.MANV,
                     nv => nv.MANV,
                     (bl, nv) => new 
                     {
                     
                        THANG = bl.THANG,
                         MANV = nv.MANV,
                         TENNV = nv.TENNV,
                         TONGTIENLUONG = bl.TONGTIENLUONG,
                     }
                 )

                 .ToList();
            dataGridView1.DataSource = lstTL;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
