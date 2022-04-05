using InfrastructureCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagementStore.Extensions
{
    public class ValidateExtensions
    {

        static Regex Validate_EmailAddress = Email_validation();
        public ValidateExtensions()
        {

        }

        // Validate information of User
        #region

        public Result Validate(string username = "", string email = "", string password = "", string repass = "")
        {
            Result result;
            result = ValidateEmail(email);
            if(result.Success)
            {
                result = ValidatePassword(password, repass); ;
            }
            
            
            return result;
        }

        public Result ValidateStringLength(string Username)
        {
            return null;
        }

        public Result ValidatePassword(string pass, string repass)
        {
            if(pass == repass)
            {
                return new Result {Success = true, Message = "Password is match" };
            }
            return new Result { Success = false, Message = "Password is not match" }; ;
        }
        public Result ValidateEmail(string email)
        {
            if(Validate_EmailAddress.IsMatch(email))
            {
                return new Result { Success = true, Message = "Email is right format" };
            }
            return new Result { Success = false, Message = "Email is wrong format" };
        }

        #endregion

        // Material for validate
        #region
        private static Regex Email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        #endregion
    }
}
