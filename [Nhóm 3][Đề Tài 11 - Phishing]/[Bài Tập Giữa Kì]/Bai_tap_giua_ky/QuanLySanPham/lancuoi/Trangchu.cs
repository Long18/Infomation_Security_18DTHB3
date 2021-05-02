using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lancuoi
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        public Boolean isExists(String name)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        //Xem form con đó đang mở hay gì 
        public void activeChildForm(String name)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    f.Activate();
                    return;
                }
            }
        }


        private void btnquanli_Click(object sender, EventArgs e)
        {
  


            if (!isExists("dangnhapadmin"))
            {
                dangnhapadmin frm = new dangnhapadmin();
               
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("dangnhapadmin");
            }
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            


            if (!isExists("doimatkhau2"))
            {
                doimatkhau2 frm = new doimatkhau2();
              
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("doimatkhau2");
            }
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            lbTKn.Text = temp;
       

        }

        public string temp;

        private void btnpb_Click(object sender, EventArgs e)
        {
            if (!isExists("doimatkhau2"))
            {
                Quanlyphongban frm = new Quanlyphongban();
                frm.hello = lbTKn.Text;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                activeChildForm("Quanlyphongban");
            }
        }
    }
}
