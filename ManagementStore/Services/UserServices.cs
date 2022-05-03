using InfrastructureCore;
using InfrastructureCore.DatabaseEngines.DAL;
using ManagementStore.Extensions;
using ManagementStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Services
{
    public class UserServices
    {
       
        private static readonly string SP_Name = "SP_USER_MANAGEMENT";
        public Result RegisterUser(AppUser user, string userId)
        {
            var resultString = "Error";
            Result result = new Result();
            try
            {
                using(var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {

                    string[] arrParams = new string[13];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Firstname";
                    arrParams[2] = "@Lastname";
                    arrParams[3] = "@Email"; arrParams[4] = "@Username";
                    arrParams[5] = "@PasswordHash"; arrParams[6] = "@Picture";
                    arrParams[7] = "@Phone"; arrParams[8] = "@Address";
                    arrParams[9] = "@Birthday"; arrParams[10] = "@Id";
                    arrParams[11] = "@TypeId"; arrParams[12] = "@UserId";

                    object[] arrParamsValue = new object[13];
                    arrParamsValue[0] = "InsertUser";
                    arrParamsValue[1] = user.Firstname;
                    arrParamsValue[2] = user.Lastname;
                    arrParamsValue[3] = user.Email;
                    arrParamsValue[4] = user.Username;
                    arrParamsValue[5] = PasswordExtensions.HashPassword(user.Password);
                    arrParamsValue[6] = user.Picture;
                    arrParamsValue[7] = user.Phone;
                    arrParamsValue[8] = user.Address;
                    arrParamsValue[9] = user.Birthday;
                    arrParamsValue[10] = user.Id;
                    arrParamsValue[11] = user.TypeId;
                    arrParamsValue[12] = userId;

                    resultString = connect.ExecuteScalar<string>(SP_Name, CommandType.StoredProcedure, arrParams, arrParamsValue);

                    if (resultString != "Error")
                    {
                        return new Result { Success = true, Data = resultString, Message = "Register user successfull" };
                    }
                    else
                    {

                        return new Result { Success = false, Message = "Register user failed" };
                    }

                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Result { Success = false, Message = ex.Message };
            }

        }
        public Result LoginUser(string uname, string password, string role)
        {
            Result result = new Result();        

            try
            {
                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
              
                    var user = GetUserByUsername(uname, role);
                    if (user == null)
                    {
                        return new Result { Success = false, Message = "Not found account!" };
                    }
                    else
                    {

                        if (PasswordExtensions.VerifyPassword(user.Password, password))
                        {
                            return new Result { Success = true, Message = "Login Successfull!", Data = user };
                        }
                        else
                        {
                            return new Result { Success = false, Message = "Login fail! Username or Password incorrect!" };
                        }
                    }                 
                }            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public AppUser GetUserByUsername(string username, string role)
        {
            AppUser user = null;
            try
            {
                
                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[3];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Username";
                    arrParams[2] = "@TypeId";

                    object[] arrParamsValue = new object[3];
                    arrParamsValue[0] = "GetUserByName";
                    arrParamsValue[1] = username;
                    arrParamsValue[2] = Convert.ToInt32(role);
        
                    var result = connect.ExecuteQuery<AppUser>(SP_Name, arrParams, arrParamsValue);
                    
                    return result.FirstOrDefault();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return user;

            }
            
        }
    }
}
