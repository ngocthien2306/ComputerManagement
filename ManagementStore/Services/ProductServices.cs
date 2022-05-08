using InfrastructureCore;
using InfrastructureCore.DatabaseEngines.DAL;
using ManagementStore.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Services
{
    public class ProductServices
    {
        
        private string SP_Name = "SP_PRODUCT";
        public Product GetOneProduct(int Id)
        {
            Product products = new Product();
  
            try
            {
                using(var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@ProductId";
                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "GetDataProduct";
                    arrParamsValue[1] = Id;
                    products = connection.ExecuteQuery<Product>(SP_Name, arrParams, arrParamsValue).FirstOrDefault();
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



        public DataTable GetListData(string query, object[] comCode, string[] param)
        {
            My_Database database = new My_Database();
            SqlCommand command = new SqlCommand(query, database.GetConnection);

            for (int i = 0; i < param.Length; i++)
            {
                command.Parameters.Add(param[i], SqlDbType.NVarChar).Value = comCode[i];
            }
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            database.Openconnection();
            adapter.Fill(table);
            database.Closeconnection();
            return table;

        }


        public Result CreateProduct(Product product, int quantity, string whCode , string userId)
        {
            try
            {
                var resultString = "Error";
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {

                    string[] arrParams = new string[16];
                    arrParams[0] = "@Method"; arrParams[1] = "@ProductName"; arrParams[2] = "@Price";
                    arrParams[3] = "@Brand"; arrParams[4] = "@CategoryId"; arrParams[5] = "@UserId";
                    arrParams[6] = "@Pricture"; arrParams[7] = "@Mainboard"; arrParams[8] = "@CPU";
                    arrParams[9] = "@RAM"; arrParams[10] = "@VGA"; arrParams[11] = "@SSD"; arrParams[12] = "@HDD";
                    arrParams[13] = "@ProductId"; arrParams[14] = "@Quantity"; arrParams[15] = "@WHCode";

                    object[] arrParamsValue = new object[16];
                    arrParamsValue[0] = "SaveData"; arrParamsValue[1] = product.ProductName;
                    arrParamsValue[2] = product.Price; arrParamsValue[3] = product.Brand;
                    arrParamsValue[4] = product.CategoryId; arrParamsValue[5] = userId;
                    arrParamsValue[6] = product.Picture; arrParamsValue[7] = product.Mainboard;
                    arrParamsValue[8] = product.CPU; arrParamsValue[9] = product.RAM;
                    arrParamsValue[10] = product.VGA; arrParamsValue[11] = product.SSD;
                    arrParamsValue[12] = product.HDD; arrParamsValue[13] = product.PId;
                    arrParamsValue[14] = quantity; arrParamsValue[15] = whCode;
                    resultString = connection.ExecuteScalar<string>(SP_Name, CommandType.StoredProcedure, arrParams, arrParamsValue);
                      
                    if (resultString == null)
                    {
                        return new Result { Success = true, Data = resultString, Message = "Save product successfull" };
                    }
                    else
                    {                   
                        return new Result { Success = false, Message = "Save product failed! " + resultString };
                    }
                    

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Result { Success = false, Message = ex.Message };
            }
        }

        public Result DeleteProduct(int id)
        {
            var resultString = "Error";
            try
            {
                using(var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@ProductId";
                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "DeleteDataProduct";
                    arrParamsValue[1] = id;
                    resultString = connection.ExecuteScalar<string>(SP_Name, CommandType.StoredProcedure, arrParams, arrParamsValue);

                    if (resultString != "Error")
                    {
                        return new Result { Success = true, Data = resultString, Message = "Delete product successfull" };
                    }
                    else
                    {

                        return new Result { Success = false, Message = "Delete product failed" };
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result { Success = false, Message = ex.Message };
            }
        }

    }
}
