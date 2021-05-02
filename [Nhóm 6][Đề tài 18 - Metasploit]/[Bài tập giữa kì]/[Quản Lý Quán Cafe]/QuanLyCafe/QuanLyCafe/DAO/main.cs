using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.DAO
{
    class main
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(
            "Data Source=.\\SQLEXPRESS;Initial Catalog=CSDL_QLCAFE;Integrated Security=True");
            return conn;
        }

        public string Converter_string(string SQL)
        {
            try
            {
                SqlConnection con = main.GetDBConnection();
                DataTable consultanttable = new DataTable();
                String stringconsultan;
                SqlDataAdapter consultanAdapter = new SqlDataAdapter(SQL, con);
                consultanAdapter.Fill(consultanttable);
                foreach (DataRow myrow in consultanttable.Rows)
                {
                    stringconsultan = Convert.ToString(myrow[0]);
                    return stringconsultan;

                }


            }
            catch
            {
                throw;
            }
            return "0";

        }


        public void excute( string SQL)
        {
            try
            {
                SqlConnection con = main.GetDBConnection();
                DataTable consultanttable = new DataTable();
                SqlDataAdapter consultanAdapter = new SqlDataAdapter(SQL, con);
                consultanAdapter.Fill(consultanttable);
            }
            catch(InvalidCastException e)
            {
                throw (e);
            }
        }
    }

}
