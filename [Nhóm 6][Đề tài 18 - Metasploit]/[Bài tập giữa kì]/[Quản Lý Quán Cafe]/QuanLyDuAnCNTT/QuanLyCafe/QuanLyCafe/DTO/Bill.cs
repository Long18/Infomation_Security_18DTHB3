using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyCafe.DTO
{
    class Bill
    {
        private int id;
        private string billDate;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        public Bill(DataRow row)
        {
            this.id = Int32.Parse(row["ID"].ToString());
            this.billDate = row["NGAYLAP"].ToString();
        }
        public Bill()
        { }
    }
}
