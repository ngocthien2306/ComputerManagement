using InfrastructureCore;
using InfrastructureCore.DatabaseEngines.DAL;
using ManagementStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Services
{
    public class WarehouseServices
    {
        private static readonly string SP_Name = "SP_WAREHOUSE";
        public List<WareHouse> GetListWarehouse()
        {
            List<WareHouse> wareHouses = new List<WareHouse>();

            try
            {
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[1];
                    arrParams[0] = "@Method";

                    object[] arrParamsValue = new object[1];
                    arrParamsValue[0] = "GetDataWarehouse";

                    wareHouses = connection.ExecuteQuery<WareHouse>(SP_Name, arrParams, arrParamsValue).ToList();
                    return wareHouses;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return wareHouses;
        }

        public Result UpdateItemWareHouse(int storedId, int quantity, string whCode, int pId, string userId)
        {
            try
            {
                var resultString = "Error";
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[6];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@StoredId";
                    arrParams[2] = "@Quantity";
                    arrParams[3] = "@WHCode";
                    arrParams[4] = "@PId";
                    arrParams[5] = "@UserId";
                    object[] arrParamsValue = new object[6];
                    arrParamsValue[0] = "SaveItemStock";
                    arrParamsValue[1] = storedId;
                    arrParamsValue[2] = quantity;
                    arrParamsValue[3] = whCode;
                    arrParamsValue[4] = pId;
                    arrParamsValue[5] = userId;
                    resultString = connection.ExecuteScalar<string>(SP_Name, arrParams, arrParamsValue);
                    if (resultString == null)
                    {
                        return new Result { Success = true, Data = resultString, Message = "Save product successfull" };
                    }
                    else
                    {
                        return new Result { Success = false, Message = "Save item in stock failed! " + resultString };
                    }
                } 
            }
            catch(Exception ex)
            {
                return new Result { Success = false, Message = ex.Message };
            }
        }

    }
}
