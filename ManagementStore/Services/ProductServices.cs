using InfrastructureCore;
using InfrastructureCore.DatabaseEngines.DAL;
using ManagementStore.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Services
{
    public class ProductServices
    {
        
        private string SP_Name = "SP_PRODUCT";
        public List<Product> GetListProduct(int Id)
        {
            List<Product> products = new List<Product>();
  
            try
            {
                using(var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Id";
                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "GetData";
                    arrParamsValue[1] = Id;
                    products = connection.ExecuteQuery<Product>(SP_Name, arrParams, arrParamsValue).ToList();
                    return products;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products; 
        }
    }
}
