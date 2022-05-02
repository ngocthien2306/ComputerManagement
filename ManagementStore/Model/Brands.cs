using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model
{
    public class Brands
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Brands(int id = 0, string name = "")
        {
            this.Id = id;
            this.Name = name;
        }
        public Brands()
        {

        }
    }

    public class Rams
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        public Rams(int id = 0, string name = "")
        {
            this.Id = id;
            this.Name = name;
        }
        public Rams()
        {

        }
    }

}
