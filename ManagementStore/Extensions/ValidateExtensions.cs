using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Extensions
{
    public class ValidateExtensions
    {
        public ValidateExtensions()
        {

        }
        public bool ValidatePassword(string pass, string repass = "")
        {
            if(pass == repass)
            {
                return true;
            }
            return false;
        }
    }
}
