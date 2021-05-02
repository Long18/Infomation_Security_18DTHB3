using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pjQLLNV
{
    public partial class ThongBao : Form
    {


        public ThongBao()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            int num1 = rand1.Next(1, 430);
            int num2 = rand1.Next(1, 300);
            int answer = num1 + num2;
          

            button1.Location = new Point(num1, num2);
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            button1.Text = temp6;

        }
        public string temp6;

    }
}
