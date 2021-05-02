using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyCafe.DTO;

namespace QuanLyCafe.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public int getLatestBill()
        {
            string query = "USP_GetLatestBill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Bill bill = new Bill(data.Rows[0]);
            return bill.Id;
        }

        public bool insertNewEmptyBill()
        {
            string query = "USP_InsertNewEmptyBill";
            int res = DataProvider.Instance.ExecuteNonQuery(query);
            return res > 0;
        }

        public DataTable getDinksBillList(string idBill)
        {
            List<DrinkBill> list = new List<DrinkBill>();
            string query = "USP_GetDrinksBill @IDBILL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
            return data;
        }
    }
}
