using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model.CommonModel
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuForm { get; set; }
        public int MenuLevel { get; set; }
        public int MenuParentId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool UseYN { get; set; }
        public bool AdminLV { get; set; }
    }
}
