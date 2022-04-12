using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model.UserModel
{
    public class UserAccessMenus
    {
        public string UserId { get; set; }
        public int MenuId { get; set; }
        public string MenuForm { get; set; }
        public string MenuName { get; set; }
        public bool SearchYN { get; set; }
        public bool CreateYN { get; set; }
        public bool SaveYN { get; set; }
        public bool DeleteYN { get; set; }
        public bool EditYN { get; set; }
        public bool PrintYN { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
