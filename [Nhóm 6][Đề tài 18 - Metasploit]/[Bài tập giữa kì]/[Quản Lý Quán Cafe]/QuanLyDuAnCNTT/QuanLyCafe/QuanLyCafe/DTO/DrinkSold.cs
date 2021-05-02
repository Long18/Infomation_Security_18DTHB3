using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyCafe.DTO
{
    class DrinkSold
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nameOfDrink;

        public string NameOfDrink
        {
            get { return nameOfDrink; }
            set { nameOfDrink = value; }
        }
        private int unitPrice;

        public int UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        private int numberOfDrink;

        public int NumberOfDrink
        {
            get { return numberOfDrink; }
            set { numberOfDrink = value; }
        }

        public DrinkSold(DataRow row)
        {
            this.id = Int32.Parse(row["ID"].ToString());
            this.nameOfDrink = row["TENTHUCUONG"].ToString();
            this.unitPrice = Int32.Parse(row["DONGIA"].ToString());
            this.numberOfDrink = Int32.Parse(row["SOLUONG"].ToString());
        }

        public DrinkSold()
        { }
    }
}
