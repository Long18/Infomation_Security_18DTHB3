using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyCafe.DTO;

namespace QuanLyCafe.DAO
{
    class DayWorkDAO
    {
        private static DayWorkDAO instance;

        public static DayWorkDAO Instance
        {
            get { if (instance == null) instance = new DayWorkDAO(); return instance; }
            private set { instance = value; }
        }

        private DayWorkDAO() { }

        public DataTable getDayWorkByIdStaff(string idStaff)
        {
            List<DayWork> list = new List<DayWork>();
            string query = "USP_GetAStaffWorkScheduleList @ID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {idStaff});
            return data;
        }

        public bool insertDayWork(string idStaff, string dayWork)
        {
            string query = "USP_InsertDayWork @idOfStaff , @dayWork";
            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idStaff, dayWork});
            return res > 0;
        }

        public bool deleteDayWork(string ID)
        {
            string query = "USP_DeleteDayWork @ID";
            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return res > 0;
        }
    }
}
