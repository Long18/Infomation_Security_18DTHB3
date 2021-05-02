using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyCafe.DTO
{
    class Staff
    {
        private int id;
        private string name;
        private string tel;
        private string address;
        private int unitSalary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int UnitSalary
        {
            get { return unitSalary; }
            set { unitSalary = value; }
        }

        public Staff()
        {
        }

        public Staff(DataRow row)
        {
            this.id = Int32.Parse(row["ID"].ToString());
            this.name = row["HOTEN"].ToString();
            this.tel = row["SDT"].ToString();
            this.address = row["DIACHI"].ToString();
            this.unitSalary = Int32.Parse(row["HESOLUONG"].ToString());
        }
    }
}
