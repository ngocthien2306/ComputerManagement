using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model
{
    public class Product
    {
        public int PId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }

        [Display(Name= "Category")]
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public byte[] Picture { get; set; }
        public string Mainboard { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string VGA { get; set; }
        public string SSD { get; set; }
        public string HDD { get; set; }

        //Attr warehouse
    }


    public class StockOutWarehouse
    {
        public int PId { get; set; }
        public string ProductName { get; set; }
        public string WHName { get; set; }
        public decimal Price { get; set; }
        public int ItemInWH { get; set; }
        public int ItemOutWh { get; set; }
        public int Total { get; set; }
        public string WHCode { get; set; }
        public int StoredId { get; set; }
        public string CategoryName { get; set; }
        public string Brand { get; set; }
        public string RAM { get; set; }
        public string CreatedBy { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
