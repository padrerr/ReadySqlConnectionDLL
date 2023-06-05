using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SqlConnLibrary
{
    public static  class SqlLibrary
    {
        static SqlConnection sqlConnection;
        public static void Connection(string server,string namedb)
        {
            sqlConnection = new SqlConnection($@"Data Source={server};Initial Catalog={namedb};Integrated Security=True");
        
        }
        public static void OpenConn()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public  static void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public static SqlConnection conn()
        {
            return sqlConnection;
        }
    }
}
