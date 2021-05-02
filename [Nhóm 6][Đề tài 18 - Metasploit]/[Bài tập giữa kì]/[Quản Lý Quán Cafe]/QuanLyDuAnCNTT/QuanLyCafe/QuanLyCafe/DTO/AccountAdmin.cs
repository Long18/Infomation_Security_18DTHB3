using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyCafe.DTO
{
    class AccountAdmin
    {
        private int id;
        private string username;
        private string password;

        public int getId()
        {
            return this.id;
        }

        public string getUsername()
        {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public AccountAdmin(DataRow row)
        {
            this.id = Int32.Parse(row["ID"].ToString());
            this.username = row["TENDANGNHAP"].ToString();
            this.password = row["MATKHAU"].ToString();
        }

        public AccountAdmin()
        { }
    }
}
