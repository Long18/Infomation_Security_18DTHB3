using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyCafe.DTO
{
    class DayWork
    {
        private int idOfStaff;
        private string dayWork;
        private int id;

        public int IdOfStaff
        {
            get { return idOfStaff; }
            set { idOfStaff = value; }
        }

        public string DayWork1
        {
            get { return dayWork; }
            set { dayWork = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DayWork(DataRow row)
        {
            this.id = Int32.Parse(row["ID"].ToString());
            this.idOfStaff = Int32.Parse(row["IDNHANVIEN"].ToString());
            this.dayWork = row["NGAYLAM"].ToString();
        }

        public DayWork()
        { }
    }
}
