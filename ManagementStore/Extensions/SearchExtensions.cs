using ManagementStore.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Extensions
{
    public static class SearchExtensions
    {
        public static ProductServices productServices;
        public static decimal StartPrice { get; set; }
        public static decimal EndPrice { get; set; }
        private static readonly decimal max = 200000000;
        public static void PriceOptionSearch(string price)
        {
            if (price == "PRIP01")
            {
                StartPrice = 0;
                EndPrice = max;
            }
            else if (price == "PRIP02")
            {
                StartPrice = 0;
                EndPrice = 5000000;
            }
            else if (price == "PRIP03")
            {
                StartPrice = 5000000;
                EndPrice = 10000000;
            }
            else if (price == "PRIP04")
            {
                StartPrice = 10000000;
                EndPrice = 15000000;
            }
            else if (price == "PRIP05")
            {
                StartPrice = 15000000;
                EndPrice = 20000000;
            }
            else if (price == "PRIP06")
            {
                StartPrice = 20000000;
                EndPrice = 30000000;
            }
            else if (price == "PRIP07")
            {
                StartPrice = 30000000;
                EndPrice = max;
            }
        

        }
        public static DataTable GetListProduct(string price, object[] arrParamsValue)
        {
            productServices = new ProductServices();
            // using function to select product data
            string query = @"select * from[dbo].[GetListProduct](@ProductName, @Brands, @Category, @Rams, @StartPrice, @EndPrice, @UserId, @WHCode)";
      
            PriceOptionSearch(price);
            string[] arrParams = new string[8];
            arrParams[0] = "@ProductName";
            arrParams[1] = "@Brands";
            arrParams[2] = "@Category";
            arrParams[3] = "@Rams";
            arrParams[4] = "@StartPrice";
            arrParams[5] = "@EndPrice";
            arrParams[6] = "@UserId";
            arrParams[7] = "@WHCode";

            
            var products = productServices.GetListData(query, arrParamsValue, arrParams);
            return products;
        }
    }
}
