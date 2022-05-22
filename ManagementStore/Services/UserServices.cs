using InfrastructureCore;
using InfrastructureCore.DatabaseEngines.DAL;
using ManagementStore.Extensions;
using ManagementStore.Model;
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

                    resultString = connect.ExecuteScalar<string>(SP_Name, CommandType.StoredProcedure, arrParams, arrParamsValue);

                    if (resultString == "Y")
                    {
                        return new Result { Success = true, Data = resultString, Message = "Register user successfull" };
                    }
                    else
                    {

                        return new Result { Success = false, Message = "Save user failed! " + resultString };
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

        public List<AppUser> GetDataUser()
        {
            List<AppUser> user = null;
            try
            {

                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[1];
                    arrParams[0] = "@Method";
              
                    object[] arrParamsValue = new object[1];
                    arrParamsValue[0] = "GetDataUser";
        

                    var result = connect.ExecuteQuery<AppUser>("SP_ADMIN", arrParams, arrParamsValue);

                    return result.ToList();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return user;

            }

        }

        public List<AppUser> GetDataUserBySearch(string fname, string lname)
        {
            List<AppUser> user = null;
            try
            {

                using (var connect = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Firstname";
                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "GetDataUserBySearch";
                    arrParamsValue[1] = fname;

                    var result = connect.ExecuteQuery<AppUser>("SP_ADMIN", arrParams, arrParamsValue);

                    return result.ToList();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return user;

            }


        }

        //vuong test
        public DataTable GetListData(string query, object[] comCode, string[] param)
        {
            My_Database database = new My_Database();
            SqlCommand command = new SqlCommand(query, database.GetConnection);

            for (int i = 0; i < param.Length; i++)
            {
                command.Parameters.Add(param[i], SqlDbType.NVarChar).Value = comCode[i];
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            database.Openconnection();
            adapter.Fill(table);
            database.Closeconnection();
            return table;

        }

        public AppUser GetOneUser(String Username)
        {
            AppUser user = new AppUser();

            try
            {
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Username";
                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "GetOneUserData";
                    arrParamsValue[1] = Username;
                    user = connection.ExecuteQuery<AppUser>(SP_Name, arrParams, arrParamsValue).FirstOrDefault();
                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return user;
        }

        public List<Userrole> GetListRole()
        {
            List<Userrole> roles = new List<Userrole>();

            try
            {
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[1];
                    arrParams[0] = "@Method";

                    object[] arrParamsValue = new object[1];
                    arrParamsValue[0] = "GetDataRole";

                    roles = connection.ExecuteQuery<Userrole>(SP_Name, arrParams, arrParamsValue).ToList();
                    return roles;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return roles;
        }

        public List<Access> GetListAccess()
        {
            List<Access> access = new List<Access>();

            try
            {
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[1];
                    arrParams[0] = "@Method";

                    object[] arrParamsValue = new object[1];
                    arrParamsValue[0] = "GetDataAccess";

                    access = connection.ExecuteQuery<Access>(SP_Name, arrParams, arrParamsValue).ToList();
                    return access;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return access;
        }

        public Result DeleteUser(String username)
        {
            var resultString = "Error";
            try
            {
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {
                    string[] arrParams = new string[2];
                    arrParams[0] = "@Method";
                    arrParams[1] = "@Username";
                    object[] arrParamsValue = new object[2];
                    arrParamsValue[0] = "DeleteUser";
                    arrParamsValue[1] = username;
                    resultString = connection.ExecuteScalar<string>(SP_Name, CommandType.StoredProcedure, arrParams, arrParamsValue);

                    if (resultString != "Error")
                    {
                        return new Result { Success = true, Data = resultString, Message = "Delete user successfull" };
                    }
                    else
                    {

                        return new Result { Success = false, Message = "Delete user failed" };
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result { Success = false, Message = ex.Message };
            }
        }

        public Result SaveUser(AppUser user, string userId)
        {
            try
            {
                var resultString = "Error";
                using (var connection = DataConnectionFactory.GetConnection(ConnectionDB.GetConnectionString()))
                {

                    string[] arrParams = new string[10];
                    arrParams[0] = "@Method"; arrParams[1] = "@UserName"; arrParams[2] = "@Firstname";
                    arrParams[3] = "@Lastname"; arrParams[4] = "@Email"; arrParams[5] = "@Phone";
                    arrParams[6] = "@Address"; arrParams[7] = "@Birthday"; arrParams[8] = "@Picture";
                    arrParams[9] = "@UserId";

                    object[] arrParamsValue = new object[10];
                    arrParamsValue[0] = "SaveData"; arrParamsValue[1] = user.Username;
                    arrParamsValue[2] = user.Firstname; arrParamsValue[3] = user.Lastname;
                    arrParamsValue[4] = user.Email; arrParamsValue[5] = user.Phone;
                    arrParamsValue[6] = user.Address; arrParamsValue[7] = user.Birthday;
                    arrParamsValue[8] = user.Picture; arrParamsValue[9] = userId;
                    resultString = connection.ExecuteScalar<string>(SP_Name, CommandType.StoredProcedure, arrParams, arrParamsValue);

                    if (resultString == null)
                    {
                        return new Result { Success = true, Data = resultString, Message = "Save user successfull" };
                    }
                    else
                    {
                        return new Result { Success = false, Message = "Save user failed! " + resultString };
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Result { Success = false, Message = ex.Message };
            }
        }
    }
}
