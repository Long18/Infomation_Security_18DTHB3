using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Data.SqlClient;

namespace Phan_mem_ngan_hang
{
    public partial class Form_giamsatcuaadmin : DevExpress.XtraEditors.XtraForm
    {
        public Form_giamsatcuaadmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BindGrid(List<CHECKLOG> listCHECKLOG)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listCHECKLOG)
            {
                int a = dataGridView1.Rows.Add();
                dataGridView1.Rows[a].Cells[0].Value = item.TENTK;
                dataGridView1.Rows[a].Cells[1].Value = item.NOIDUNG;
                dataGridView1.Rows[a].Cells[2].Value = item.THOIGIAN;
                //dataGridView1.Rows[a].Cells[3].Value = item.thoigiandangxuat;



            }
        }

        private void Form_giamsatcuaadmin_Load(object sender, EventArgs e)
        {

            DBcontext context = new DBcontext();
            List<CHECKLOG> listCHECKLOG = context.CHECKLOGs.ToList();
           
            BindGrid(listCHECKLOG);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if(rbt_tat.Checked)
            {
                MessageBox.Show("Bạn không thể tắt chức năng giám sát", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    

           
        }
        private void loadData()
        {
            //Model2 context1 = new Model2();
            //List<checklog> checklogs = context1.checklogs.ToList();
            DBcontext context = new DBcontext();
            List<CHECKLOG> listchecklog = context.CHECKLOGs.ToList();
            bang(listchecklog);
            //List<NHANVIEN> listnhanhvien = context.NHANVIENs.ToList();


        }
        private void bang(List<CHECKLOG> listCHECKLOG)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listCHECKLOG)
            {
                int a = dataGridView1.Rows.Add();
                dataGridView1.Rows[a].Cells[0].Value = item.TENTK;
                dataGridView1.Rows[a].Cells[1].Value = item.NOIDUNG;
                dataGridView1.Rows[a].Cells[2].Value = item.THOIGIAN;
                
            }
        }
        private void btn_xoalichsu_Click(object sender, EventArgs e)
        {
            DBcontext context = new DBcontext();
            CheckBox delete = new CheckBox();
            SqlCommand com = new SqlCommand();
            String sql = "DELETE FROM CHECKLOG";
            //SqlDataAdapter da = new SqlDataAdapter("");
            if (MessageBox.Show("Bạn có chắc muốn xóa tất cả lịch sử","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RL8FVB7;Initial Catalog=QLNH;Integrated Security=True");
                conn.Open();
                //context.CHECKLOGs.Remove(CheckBox);
                //context.CHECKLOGs..CommandText = "DELETE FROM CHECKLOG";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //context.SaveChanges();
                
            }
            loadData();
            /*SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RL8FVB7;Initial Catalog=QLNH;Integrated Security=True");
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = "DELETE FROM CHECKLOG";
           // SqlDataAdapter data = com.ExecuteReader();
            conn.Close();
            loadData();*/

        }

        private void rbt_bat_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbt_tat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_bat.Checked == false)
            {
                MessageBox.Show("Bạn không thể tắt chức năng giám sát", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rbt_bat.Checked = true;
            }
            /*if(rbt_bat.AutoCheck)
            {
                MessageBox.Show("Bạn không thể tắt chức năng giám sát", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            } */
        }
    }
}