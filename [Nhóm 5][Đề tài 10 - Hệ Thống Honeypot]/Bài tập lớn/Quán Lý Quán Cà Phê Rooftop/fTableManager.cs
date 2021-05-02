using qlquancf.DAO;
using qlquancf.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlquancf
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();
            //ChangeAccount(loginAccount.Type);
            this.LoginAccount = acc;

            LoadCategory();
            LoadTable();
            LoadComboboxTable(cbSwitchTable);
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        #region Method

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            dang.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach ( Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                //đổi màu bàn 1:trống ,2 : có người 
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aquamarine;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }


        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<qlquancf.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (qlquancf.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());         
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //chuyển tổng  tiền thành vn đồng 
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        #endregion

        #region Events

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Account n = new Account();
            Model1 t = new Model1();
            checklog u = new checklog();

            string v = "nguoidung: " + loginAccount.DisplayName + ",vuamoi : " + đăngToolStripMenuItem.Text;

            DateTime time = DateTime.Now;
            // DateTime time = DateTime.Now;
            string b = time.ToString("dd/MM/yyyy, HH:mm:ss");
            u.ngay = b;
            u.noidung = v;
            t.checklogs.Add(u);
         //   t.checklogs.Add();
          
            t.SaveChanges();
            
            this.Close();
        }
      

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
           

            dang.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ") ";
        }
        
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;//tránh xóa tài khoản admin
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
            f.UpdateTable += f_UpdateTable;
            f.DeleteTable += f_DeleteTable;
            f.InsertTable += f_InsertTable;
            f.UpdateCategory += f_UpdateCategory;
            f.DeleteCategory += f_DeleteCategory;
            f.InsertCategory += f_InsertCategory;
            f.ShowDialog();
        }
        //----------------------Food---------------------------
        //Tạo events để phần mềm chạy linh hoạt hơn(không cần thoát ra vô lại)
        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }
        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }
        //------------------Table----------------------
        void f_UpdateTable(object sender, EventArgs e)
        {
            LoadTable();
            
        }
        void f_DeleteTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        void f_InsertTable(object sender, EventArgs e)
        {
            LoadTable();
        }
        
        //---------------------Category------------------------------
        void f_UpdateCategory(object sender, EventArgs e)
        {
            LoadCategory();
        }
        void f_DeleteCategory(object sender, EventArgs e)
        {
            LoadCategory();
        }

        void f_InsertCategory(object sender, EventArgs e)
        {
            LoadCategory();
        }
        
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);

            LoadTable();
        }
        

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

         
          

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;

            //double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0].Replace(".", ""));
            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
               
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);
                  
                }

            }
            Account n = new Account();
            Model1 t = new Model1();
            checklog u = new checklog();

            string v = "nguoidung: " + loginAccount.DisplayName + ",vuamoi : " + btnCheckOut.Text;

            DateTime time = DateTime.Now;
            // DateTime time = DateTime.Now;
            string b = time.ToString("dd/MM/yyyy, HH:mm:ss");
            u.ngay = b;
            u.noidung = v;
            t.checklogs.Add(u);
            t.SaveChanges();
        }
        
        

        private void btnSwitchTable_Click_1(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Account n = new Account();
                Model1 t = new Model1();
                checklog u = new checklog();

                string v = "nguoidung: " + loginAccount.DisplayName + ",vuamoi : " + btnSwitchTable.Text;

                DateTime time = DateTime.Now;
                // DateTime time = DateTime.Now;
                string b = time.ToString("dd/MM/yyyy, HH:mm:ss");
                u.ngay = b;
                u.noidung = v;
                t.checklogs.Add(u);
                //   t.checklogs.Add();

                t.SaveChanges();

                TableDAO.Instance.SwitchTable(id1, id2);

                LoadTable();
            }
        }

        //---cách lười
        private void thànhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnCheckOut_Click(this, new EventArgs());
         
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
        }
        #endregion
        //----------------------------------------------------------------
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void cbSwitchTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
