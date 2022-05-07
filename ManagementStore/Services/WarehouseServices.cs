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
    }
}
