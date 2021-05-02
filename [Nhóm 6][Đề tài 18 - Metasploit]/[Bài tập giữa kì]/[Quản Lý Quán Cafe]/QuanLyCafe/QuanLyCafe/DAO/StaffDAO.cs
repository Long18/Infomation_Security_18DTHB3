using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyCafe.DTO;

namespace QuanLyCafe.DAO
{
    class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }

        private StaffDAO() { }

        public DataTable getStaffsList()
        {
            string query = "USP_GetStaffsList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool insertStaff(string name, string tel, string address, string unitSalary)
        {
            string query = "USP_InsertStaff @name , @tel , @address , @unitSalary";
            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, tel, address, unitSalary });
            return res > 0;
        }

        public bool deleteStaff(string ID)
        {
            string query = "USP_DeleteStaff @ID";
            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return res > 0;
        }

        public bool updateStaff(string id, string name, string tel, string address, string unitSalary)
        {
            string query = "USP_UpdateStaff @ID , @NAME , @TEL , @ADDRESS , @UNITSALARY";
            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, tel, address, unitSalary });
            return res > 0;
        }

        public DataTable getWorkDayStaffList(string start, string end)
        {
            string query = "USP_GetWorkDayStaffList @START , @END";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{ start, end });
            return data;
        }
    }
}
