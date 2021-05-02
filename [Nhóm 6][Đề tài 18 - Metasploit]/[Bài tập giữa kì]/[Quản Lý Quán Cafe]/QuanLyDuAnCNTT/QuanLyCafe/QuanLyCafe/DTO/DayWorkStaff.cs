using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyCafe.DTO
{
    class DayWorkStaff
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int numberOfWorkDay;

        public int NumberOfWorkDay
        {
            get { return numberOfWorkDay; }
            set { numberOfWorkDay = value; }
        }
        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public DayWorkStaff(DataRow row)
        {
            this.id = Int32.Parse(row["ID"].ToString());
            this.name = row["HOTEN"].ToString();
            this.numberOfWorkDay = Int32.Parse(row["SONGAYLAM"].ToString());
            this.salary = Int32.Parse(row["LUONG"].ToString());
        }

        public DayWorkStaff()
        { }
    }
}
