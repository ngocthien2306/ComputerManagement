using InfrastructureCore;
using InfrastructureCore.DatabaseEngines.DAL;
using ManagementStore.Extensions;
using ManagementStore.Model.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Services
{
    public class UserServices
    {
       
        private static readonly string SP_Name = "SP_USER_MANAGEMENT";
        private static readonly string SP_ADMIN = "SP_ADMIN";

        public Result RegisterUser(AppUser user, string userId)
        {
            var resultString = "Y";
            Result result = new Result();
            try
            {
                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {

                        string[] arrParams = new string[7];
                        arrParams[0] = "@Method";
                        arrParams[1] = "@Firstname";
                        arrParams[2] = "@Lastname";
                        arrParams[3] = "@Email";
                        arrParams[4] = "@Username";
                        arrParams[5] = "@PasswordHash"; arrParams[6] = "@RoleId";

                    object[] arrParamsValue = new object[13];
                    arrParamsValue[0] = "SaveDataUser";
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

                        resultString = connect.ExecuteScalar<string>(SP_Name, CommandType.StoredProcedure, arrParams, arrParamsValue, transaction);
                        transaction.Commit();
                        if(resultString != "Error")
                        {
                            return new Result { Success = true, Data = resultString, Message = "Register user successfull" };
                        }
                        else
                        {
                            transaction.Rollback();
                            return new Result { Success = false, Message = "Register user failed" };
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Result { Success = false, Message = ex.Message };
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

                    AppUser user = GetUserByUsername(uname);
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
                            return new Result { Success = true, Message = "Login Successfull!", Data = user };
                        }
                        else
                        {
                            return new Result { Success = false, Message = "Login fail! Username or Password incorrect!" };
                        }
                    }
                    



                }            
            }
            catch (Exception ex)
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
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Username";
                    arrParams[2] = "@RoleId";

                    object[] arrParamsValue = new object[2];
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
