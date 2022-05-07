using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Extensions
{
    public static class OptionSearchExtensions
    {
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
    }
}
