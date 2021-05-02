using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCafe.DTO
{
    class ActivityLog
    {
        private string UserID;
        private string Employee;
        private string Timestamp;
        private string Function;
        private string IPaddress;

        public string userID
        {
            get { return UserID; }
            set { UserID = value; }
        }
        public string employee
        {
            get { return Employee; }
            set { Employee = value; }
        }
        public string timestamp
        {
            get { return Timestamp; }
            set { Timestamp = value; }
        }
        public string function
        {
            get { return Function; }
            set { Function = value; }
        }
        public string iPaddress
        {
            get { return IPaddress; }
            set { IPaddress = value; }
        }

        public ActivityLog(DataRow row)
        {
            this.UserID = row["userid"].ToString();
            this.Employee = row["Employee"].ToString();
            this.Timestamp = row["Timestamp"].ToString();
            this.Function = row["Function"].ToString();
            this.IPaddress = row["IPaddress"].ToString();
        }

    }
}
