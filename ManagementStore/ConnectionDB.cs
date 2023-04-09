﻿using System;
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
        private static readonly string SqlString = @"Data Source=26.209.131.79, 1433;Initial Catalog=ComputerStore;Persist Security Info=True;User ID=ngocthien; Password=thien123";
        static SqlConnection connection = new SqlConnection(SqlString);
        public static string GetConnectionString()
        {
            return SqlString;
        }
        public static void SetConnectionString(string login, string password)
        {
            string connect = "Data Source=HERMES;Initial Catalog=ComputerStore;Integrated Security=True";
            SqlString = @connect;
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
    public class My_Database
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HERMES;Initial Catalog=ComputerStore;Integrated Security=True");
        public SqlConnection GetConnection
        {
            get { return this.connect; }
        }
        public void Openconnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void Closeconnection()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
