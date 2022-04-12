using InfrastructureCore;
using InfrastructureCore.DatabaseEngines.DAL;
using ManagementStore.Extensions;
using ManagementStore.Model.UserModel;
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

        private static readonly string SP_USER_MANAGEMENT = "SP_USER_MANAGEMENT";
        private static readonly string SP_GROUP_ACCESS_MENU = "SP_GROUP_ACCESS_MENU";
        private static readonly string SP_USER_ACCESS_MENU = "SP_USER_ACCESS_MENU";
        //Get Method
        #region 
        public List<GroupAccessMenu> GetListGroupAccessMenus(int GroupId)
        {
            
            List<GroupAccessMenu> groupAccessMenu = null;
            try
            {
                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@GroupId";


                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "GetListGroupAccessMenus";
                    arrParamsValue[1] = GroupId;

                    groupAccessMenu = connect.ExecuteQuery<GroupAccessMenu>(SP_GROUP_ACCESS_MENU, arrParams, arrParamsValue).ToList();

                    return groupAccessMenu;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<UserAccessMenus> GetListUserAccessMenus(string UserId)
        {

            List<UserAccessMenus> userAccessMenus = null;
            try
            {
                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@UserId";


                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "GetListUserAccessMenus";
                    arrParamsValue[1] = UserId;

                    userAccessMenus = connect.ExecuteQuery<UserAccessMenus>(SP_USER_ACCESS_MENU, arrParams, arrParamsValue).ToList();

                    return userAccessMenus;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion
        public Result RegisterUser(AppUser user, string createdBy)
        {
            var resultString = "Error";
            Result result = new Result();
            try
            {
                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
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
                        arrParams[5] = "@PasswordHash";
                        arrParams[6] = "@RoleId";

                        object[] arrParamsValue = new object[7];
                        arrParamsValue[0] = "InsertUser";
                        arrParamsValue[1] = user.Firstname;
                        arrParamsValue[2] = user.Lastname;
                        arrParamsValue[3] = user.Email;
                        arrParamsValue[4] = user.Username;
                        arrParamsValue[5] = PasswordExtensions.HashPassword(user.Password);
                        arrParamsValue[6] = role;

                        resultString = connect.ExecuteScalar<string>(SP_USER_MANAGEMENT, CommandType.StoredProcedure, arrParams, arrParamsValue, transaction);
                        transaction.Commit();
                        if (resultString != "Error")
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Result { Success = false, Message = ex.Message };
            }
         
        }

        public Result LoginUser(string uname, string password)
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
                        bool checkPass = PasswordExtensions.VerifyPassword(user.Password, password);

                        if (checkPass)
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

        public AppUser GetUserByUsername(string username)
        {
            AppUser user = null;
            try
            {

                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Username";


                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "GetUserByName";
                    arrParamsValue[1] = username;

                    var result = connect.ExecuteQuery<AppUser>(SP_USER_MANAGEMENT, arrParams, arrParamsValue);

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
