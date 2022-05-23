using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model
{
    public class CommonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CommonModel(int id = 0, string name = "")
        {
            this.Id = id;
            this.Name = name;
        }
        public CommonModel()
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

    public class Behavior
    {
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Status { get; set; }
        public DateTime Time { get; set; }
        public string Data { get; set; }
    }



}
