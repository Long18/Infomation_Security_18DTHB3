using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using QuanLyCafe.DTO;

namespace QuanLyCafe.DAO
{
    class AccountAdminDAO
    {
        private static AccountAdminDAO instance;

        public static AccountAdminDAO Instance
        {
            get { if (instance == null) instance = new AccountAdminDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountAdminDAO() { }

        private string encode(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @USERNAME , @PASSWORD";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username , encode(password) });

            return result.Rows.Count > 0;
        }

        public DataTable getAccountAdminsList()
        {
            List<AccountAdmin> list = new List<AccountAdmin>();
            string query = "USP_GetAccountAdminsList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool insertAccountAdmin(string username, string password)
        {
            string query = "USP_InsertAccountAdmin @username , @password";
            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, encode(password) });
            return res > 0;
        }

        public bool deleteAccountAmin(string ID)
        {
            string query = "USP_DeleteAccountAdmin @ID";
            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return res > 0;
        }

        public bool updateAccountAmin(string id, string username, string password)
        {
            string query = "USP_UpdateAccountAdmin @ID , @NAME , @UNITPRICE";
            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, username, encode(password) });
            return res > 0;
        }
    }
}
