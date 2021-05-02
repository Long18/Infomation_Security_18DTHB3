using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyCafe.DTO
{
    class DrinkBill
    {
        private string nameOfDrink;
        private int unitPrice;
        private int numberOfDrink;

        public int NumberOfDrink
        {
            get { return numberOfDrink; }
            set { numberOfDrink = value; }
        }

        public string getNameOfDrink()
        {
            return this.nameOfDrink;
        }

        public int getUnitPrice()
        {
            return this.unitPrice;
        }

        public void setNameOfDrink(string nameOfDrink)
        {
            this.nameOfDrink = nameOfDrink;
        }

        public void setUnitPrice(int unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public DrinkBill(DataRow row)
        {
            this.nameOfDrink = row["TENTHUCUONG"].ToString();
            this.unitPrice = Int32.Parse(row["DONGIA"].ToString());
            this.numberOfDrink = Int32.Parse(row["SOLUONG"].ToString());
        }

        public DrinkBill() 
        { }
    }
}
