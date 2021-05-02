using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.DTO;
using System.Data;


namespace QuanLyCafe.DAO
{
    class ActivityLogDAO
    {
        private static ActivityLogDAO instance;

        public static ActivityLogDAO Instance
        {
            get { if (instance == null) instance = new ActivityLogDAO(); return instance; }
            private set { instance = value; }
        }

        private ActivityLogDAO() { }

        public DataTable getActivityLog()
        {
            string query = "USP_GetActivi";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }





    }
}
