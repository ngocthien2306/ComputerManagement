using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public AppUser(int id = 0, string fname = "", string lname = "", string email = "", string uname = "", string pass = "", int rid = 0)
        {
            this.Id = id;
            this.Firstname = fname;
            this.Lastname = lname;
            this.Email = email;
            this.Username = uname;
            this.Password = pass;
            this.RoleId = rid;
        }
        public AppUser()
        {

        }

    }
}
