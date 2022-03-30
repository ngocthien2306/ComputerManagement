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
        public Result RegisterUser(AppUser user, string createdBy)
        {
            var resultString = "Error";
            Result result = new Result();
            try
            {
                using(var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    using (var transaction = connect.BeginTransaction())
                    {
                        int role = createdBy == "Manager" ? 2 : 3;

                        string[] arrParams = new string[7];
                        arrParams[0] = "@Method";
                        arrParams[1] = "@Firstname";
                        arrParams[2] = "@Lastname";
                        arrParams[3] = "@Email";
                        arrParams[4] = "@Username";
                        arrParams[5] = "@PasswordHash"; arrParams[6] = "@RoleId";

                        object[] arrParamsValue = new object[7];
                        arrParamsValue[0] = "InsertUser";
                        arrParamsValue[1] = user.Firstname;
                        arrParamsValue[2] = user.Lastname;
                        arrParamsValue[3] = user.Email;
                        arrParamsValue[4] = user.Username;
                        arrParamsValue[5] = PasswordExtensions.HashPassword(user.Password);
                        arrParamsValue[6] = role;

                        resultString = connect.ExecuteScalar<string>(SP_Name, CommandType.StoredProcedure, arrParams, arrParamsValue, transaction);
                        transaction.Commit();
                        if(resultString != "Error")
                        {
                            return new Result { Success = true, Data = resultString, Message = "Register user successfull" };
                        }
                        else
                        {
                            transaction.Rollback();
                            return new Result { Success = false, Message = "Register user successfull" };
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
        public Result LoginUser(string uname, string password, int role)
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
                        string[] arrParams = new string[4];
                        arrParams[0] = "@Method";
                        arrParams[1] = "@Username";
                        arrParams[2] = "@PasswordHash";
                        arrParams[3] = "@RoleId";

                        object[] arrParamsValue = new object[5];
                        arrParamsValue[0] = "LoginUser";
                        arrParamsValue[1] = uname;
                        arrParamsValue[2] = user.Password;
                        arrParamsValue[3] = role;
                        var userLogin = connect.ExecuteQuery<AppUser>(SP_Name, arrParams, arrParamsValue).First();

                        if (userLogin != null)
                        {
                            return new Result { Success = true, Message = "Login Successfull!", Data = userLogin.RoleId };
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

        public AppUser GetUserByUsername(string username, int role)
        {
            AppUser user = null;
            try
            {
                
                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[3];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Username";
                    arrParams[2] = "@RoleId";

                    object[] arrParamsValue = new object[3];
                    arrParamsValue[0] = "GetUserByName";
                    arrParamsValue[1] = username;
                    arrParamsValue[2] = role;
                    var result = connect.ExecuteQuery<AppUser>(SP_Name, arrParams, arrParamsValue);

                    return result.FirstOrDefault();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return user;
        }
    }
}
