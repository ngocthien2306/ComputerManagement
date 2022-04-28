using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore
{
    public static class ConnectionDB
    {
        private static readonly string SqlString = @"Data Source=26.178.255.191, 1433;Initial Catalog=ComputerStore;Persist Security Info=True;User ID=thiennguyen; Password=ngocthien";
        static SqlConnection connection = new SqlConnection(SqlString);
        public static string GetConnectionString()
        {
            return SqlString;
        }
        public static SqlConnection GetConnection
        {
            get { return connection; }
        }

        public static void OpenConnect()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnect()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
