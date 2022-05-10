using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model
{
    public class WareHouse
    {
        public int WHId { get; set; }
        public string WHName { get; set; }
        public int Capacity { get; set; }
        public string WHCode { get; set; }
    }
    public class WareHouseItem
    {
        public int Id { get; set; }
        public int WHId { get; set; }
        public int PId { get; set; }
        public int Total { get; set; }
        public int ItemInWH { get; set; }
        public int ItemOutWh { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class HistoryInAndOutProduct
    {
        public int HId { get; set; }
        public int Amount { get; set; }
        public int ItemInWH { get; set; }
        public int ItemOutWh { get; set; }
        public string InOrOut { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string RAM { get; set; }
        public string Brand { get; set; }
        public string WHName { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
