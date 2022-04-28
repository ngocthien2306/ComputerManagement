using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model
{
    public class AppUser
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public byte[] Picture { get; set; }

        public AppUser(string id = "", string fname = "", string lname = "", string email = "", string uname = "", string pass = "", byte[] picture = default)
        {
            this.Id = id;
            this.Firstname = fname;
            this.Lastname = lname;
            this.Email = email;
            this.Username = uname;
            this.Password = pass;
            this.Picture = picture;
  
        }
        public AppUser()
        {

        }

    }
}
