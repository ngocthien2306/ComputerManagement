using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name= "Category Id")]
        public int CategoryId { get; set; }
        public decimal Price { get; set; }


    }
}
