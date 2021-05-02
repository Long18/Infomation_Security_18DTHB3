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
    public partial class Trangchu : DevExpress.XtraEditors.XtraUserControl
    {
        private static Trangchu _trangchu;
        public static Trangchu trangchu
        {
            get
            {
                if (_trangchu == null)
                {
                    _trangchu = new Trangchu();
                }
                return _trangchu;
            }
        }
        public Trangchu()
        {
            InitializeComponent();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\z2177129791033_5351bfbea34ae50da165738119c79a41.jpg");
        }

        internal void BackgroundImageLayoutChanged()
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
