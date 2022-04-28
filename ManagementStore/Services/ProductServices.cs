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


        public List<Category> GetListCategory()
        {
            List<Category> categorys = new List<Category>();

            try
            {
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[1];
                    arrParams[0] = "@Method";

                    object[] arrParamsValue = new object[1];
                    arrParamsValue[0] = "GetDataCategory";

                    categorys = connection.ExecuteQuery<Category>(SP_Name, arrParams, arrParamsValue).ToList();
                    return categorys;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return categorys;
        }

        public List<Brands> GetListBrand()
        {
            List<Brands> brands = new List<Brands>();
            brands.Add(new Brands { Id = 1, Name = "ASUS" });
            brands.Add(new Brands { Id = 2, Name = "LENOVO" });
            brands.Add(new Brands { Id = 3, Name = "ACER" });
            brands.Add(new Brands { Id = 4, Name = "MSI" });
            brands.Add(new Brands { Id = 5, Name = "HP" });
            brands.Add(new Brands { Id = 6, Name = "MACBOOK" });
            brands.Add(new Brands { Id = 7, Name = "DELL" });


            return brands;
        }


    }
}
