using InfrastructureCore.DatabaseEngines.Extensions;
using InfrastructureCore.DatabaseEngines.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InfrastructureCore.DatabaseEngines.Engines
{
    public class MsDbConnection : MsDbDacBase, IDataConnection
    {
        #region Variable
        public static string DefaultConnectionString = string.Empty;
        private const int INTERVAL_SCHEDULE = 3000;
        private const int CONN_TIMES = 3;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor, provide SubSystemType to indicate which ConnectionString in machine.config 
        /// to use
        /// </summary>
        /// <param name="susSystemType"></param>
        public MsDbConnection()
            : base(DefaultConnectionString)
        {
        }

        public MsDbConnection(string connectionString)
            : base(connectionString)
        {

        }
        #endregion

        #region ExecuteQuery

        /// <summary>
        /// Added on 01/23 Loc
        /// </summary>
        private void ExecuteOptimize()
        {
            SetSqlCommand(SqlCommandType.SelectCommand, "SET ARITHABORT ON", CommandType.Text);
            ExecuteNonQuery(false);
        }

        /// <summary>
        /// Return Dataset with 1 table
        /// </summary>
        /// <param name="storedProcName">Stored Procedure Name</param>
        /// <param name="parameters">list of parameters including name & value</param>
        /// <returns></returns>
        public DataSet ExecuteQuery(string storedProcName, string[] paramNames, object[] paramValues)
        {
            return ExecuteQuery(storedProcName, CommandType.StoredProcedure, paramNames, paramValues, null);
        }
        public async Task<DataSet> ExecuteQueryAsync(string storedProcName, string[] paramNames, object[] paramValues)
        {
            return await ExecuteQueryAsync(storedProcName, CommandType.StoredProcedure, paramNames, paramValues, null);
        }
        public DataSet ExecuteQuery(string storedProcName, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            return ExecuteQuery(storedProcName, CommandType.StoredProcedure, paramNames, paramValues, trans);
        }
        public async Task<DataSet> ExecuteQueryAsync(string storedProcName, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            return await ExecuteQueryAsync(storedProcName, CommandType.StoredProcedure, paramNames, paramValues, trans);
        }
        public DataSet ExecuteQueryText(string storedProcName, string[] paramNames, object[] paramValues)
        {
            return ExecuteQuery(storedProcName, CommandType.Text, paramNames, paramValues, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeOutInSeconds"></param>
        /// <param name="commandType"></param>
        /// <param name="storedProcName"></param>
        /// <param name="paramNames"></param>
        /// <param name="paramValues"></param>
        /// <returns></returns>
        public DataSet ExecuteQuery(string storedProcName, CommandType commandType, string[] paramNames, object[] paramValues)
        {
            return ExecuteQuery(storedProcName, commandType, paramNames, paramValues, null);
        }
        public async Task<DataSet> ExecuteQueryAsync(string storedProcName, CommandType commandType, string[] paramNames, object[] paramValues)
        {
            return await ExecuteQueryAsync(storedProcName, commandType, paramNames, paramValues, null);
        }
        /// <summary>
        /// Return Dataset with 1 table
        /// </summary>
        /// <param name="timeOutInSeconds">Timeout in seconds</param>
        /// <param name="storedProcName">Stored Procedure Name</param>
        /// <param name="parameters">list of parameters including name & value</param>
        /// <returns></returns>
        public DataSet ExecuteQuery(string storedProcName, CommandType commandType, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            DataSet dsReturn = null;
            DateTime startExecute = DateTime.Now;

            SetSqlCommand(SqlCommandType.SelectCommand, storedProcName, commandType);

            string paramName = string.Empty;
            ParameterDirection paramDirection = ParameterDirection.InputOutput;
            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    paramDirection = paramNames[i][0] != '@' ? ParameterDirection.InputOutput : ParameterDirection.Input;
                    paramName = paramNames[i][0] != '@' ? paramNames[i].Substring(paramNames[i].IndexOf("@")) : paramNames[i];


                    SqlParameter param = AddSqlParameter(SqlCommandType.SelectCommand, paramName, paramValues[i]);
                    param.Direction = paramDirection;
                }
            }

            if (trans != null)
            {
                loadCommand.Transaction = trans;
            }
            dsReturn = ExecuteFill();
            return dsReturn;
        }
        public async Task<DataSet> ExecuteQueryAsync(string storedProcName, CommandType commandType, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            DataSet dsReturn = null;
            DateTime startExecute = DateTime.Now;

            SetSqlCommand(SqlCommandType.SelectCommand, storedProcName, commandType);

            string paramName = string.Empty;
            ParameterDirection paramDirection = ParameterDirection.InputOutput;
            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    paramDirection = paramNames[i][0] != '@' ? ParameterDirection.InputOutput : ParameterDirection.Input;
                    paramName = paramNames[i][0] != '@' ? paramNames[i].Substring(paramNames[i].IndexOf("@")) : paramNames[i];

                    SqlParameter param = AddSqlParameter(SqlCommandType.SelectCommand,
                        paramName, paramValues[i]);
                    param.Direction = paramDirection;
                }
            }

            if (trans != null)
            {
                loadCommand.Transaction = trans;
            }
            dsReturn = await ExecuteFillAsync();
            return dsReturn;
        }
        //////
        public IEnumerable<T> ExecuteQuery<T>(string commandText, string[] paramNames, object[] paramValues)
        {
            var ds = ExecuteQuery(commandText, paramNames, paramValues);
            return ds.FromDataSet<T>();
        }

        public List<List<MapFieldDBModel>> ExecuteQuery2(string commandText, string[] paramNames, object[] paramValues)
        {
            var ds = ExecuteQuery(commandText, paramNames, paramValues);
            return ds.FromDataSet();
        }

        public async Task<IEnumerable<T>> ExecuteQueryAsync<T>(string commandText, string[] paramNames, object[] paramValues)
        {
            var ds = await ExecuteQueryAsync(commandText, paramNames, paramValues);
            return ds.FromDataSet<T>();
        }
        // call SP
        public IEnumerable<T> ExecuteQuery<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues)
        {
            //var ds = ExecuteQuery(commandText, CommandType.StoredProcedure, paramNames, paramValues);
            var ds = ExecuteQuery(commandText, commandType, paramNames, paramValues);
            return ds.FromDataSet<T>();
        }
        public async Task<IEnumerable<T>> ExecuteQueryAsync<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues)
        {
            //var ds = ExecuteQuery(commandText, CommandType.StoredProcedure, paramNames, paramValues);
            var ds = await ExecuteQueryAsync(commandText, commandType, paramNames, paramValues);
            return ds.FromDataSet<T>();
        }
        #endregion

        #region ExecuteQueryDataRow

        /// <summary>
        /// Return a single Row or null
        /// </summary>
        /// <param name="subSystemType"></param>
        /// <param name="storedProcName"></param>
        /// <param name="paramNames"></param>
        /// <param name="paramValues"></param>
        /// <returns></returns>
        public DataRow ExecuteQueryDataRow(string storedProcName, string[] paramNames, object[] paramValues)
        {
            DataSet ds = ExecuteQuery(storedProcName, paramNames, paramValues);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
                return ds.Tables[0].Rows[0];
            else
                return null;
        }

        /// <summary>
        /// Return a single Row or null
        /// </summary>
        /// <param name="timeOutInSeconds">Timeout in seconds</param>
        /// <param name="subSystemType"></param>
        /// <param name="storedProcName"></param>
        /// <param name="paramNames"></param>
        /// <param name="paramValues"></param>
        /// <returns></returns>
        public DataRow ExecuteQueryDataRow(string storedProcName, CommandType commandType, string[] paramNames, object[] paramValues)
        {
            DataSet ds = ExecuteQuery(storedProcName, commandType, paramNames, paramValues, null);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
                return ds.Tables[0].Rows[0];
            else
                return null;
        }

        #endregion

        #region ExecuteNonQuery - Use Trans

        /// <summary>
        /// Execute s SQL
        /// </summary>
        /// <param name="commandText">Stored Procedure Name</param>
        /// <param name="parameters">list of parameters including name & value</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string commandText, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            return ExecuteNonQuery(commandText, CommandType.Text, paramNames, paramValues, trans);
        }

        /// <summary>
        /// Execute s SQL
        /// </summary>
        /// <param name="timeOutInSeconds">Timeout in seconds</param>
        /// <param name="commandText">Stored Procedure Name</param>
        /// <param name="parameters">list of parameters including name & value</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            SetSqlCommand(SqlCommandType.SelectCommand, commandText, commandType);

            string paramName = string.Empty;
            ParameterDirection paramDirection = ParameterDirection.InputOutput;
            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    paramDirection = paramNames[i][0] != '@' ? ParameterDirection.InputOutput : ParameterDirection.Input;
                    paramName = paramNames[i][0] != '@' ? paramNames[i].Substring(paramNames[i].IndexOf("@")) : paramNames[i];

                    SqlParameter param = AddSqlParameter(SqlCommandType.SelectCommand,
                        paramName, paramValues[i]);
                    param.Direction = paramDirection;
                }
            }

            return ExecuteNonQuery(trans);
        }


        #endregion

        #region ExecuteScalar - Trans

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="paramNames"></param>
        /// <param name="paramValues"></param>
        /// <returns></returns>
        public object ExecuteScalar(string commandText, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            return ExecuteScalar(commandText, CommandType.Text, paramNames, paramValues, trans);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="paramNames"></param>
        /// <param name="paramValues"></param>
        /// <returns></returns>
        public object ExecuteScalar(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            object objReturn = null;
            SetSqlCommand(SqlCommandType.SelectCommand, commandText, commandType);

            string paramName = string.Empty;
            ParameterDirection paramDirection = ParameterDirection.InputOutput;
            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    paramDirection = paramNames[i][0] != '@' ? ParameterDirection.InputOutput : ParameterDirection.Input;
                    paramName = paramNames[i][0] != '@' ? paramNames[i].Substring(paramNames[i].IndexOf("@")) : paramNames[i];

                    SqlParameter param = AddSqlParameter(SqlCommandType.SelectCommand,
                        paramName, paramValues[i]);
                    param.Direction = paramDirection;
                }
            }

            objReturn = ExecuteScalar(trans);
            return objReturn;
        }

        #endregion

        #region ExecuteUpdateData

        /// <summary>
        /// Update multi-rows to database
        /// </summary>
        /// <param name="changedDS"></param>
        /// <param name="storedProcName"></param>
        /// <param name="paramNames"></param>
        /// <param name="tableName"></param>
        /// <param name="useTransaction"></param>
        /// <returns></returns>
        public bool ExecuteUpdateData2(ref DataSet changedDS, string storedProcName, string[] paramNames, string tableName, bool useTransaction)
        {
            bool boolData = false;
            SetSqlCommand(SqlCommandType.InsertCommand, storedProcName);
            AddSqlParameter(SqlCommandType.InsertCommand, "@actionID", SqlDbType.Char, 6, "INSERT");

            string paramName = string.Empty;
            ParameterDirection paramDirection = ParameterDirection.InputOutput;
            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    string pType = GetSqlDbTypeName(paramNames[i], out paramName);
                    paramDirection = paramName[0] != '@' ? ParameterDirection.InputOutput : ParameterDirection.Input;
                    paramName = paramName[0] != '@' ? paramName.Substring(paramName.IndexOf("@")) : paramName;

                    AddSqlParameter(SqlCommandType.InsertCommand, paramName,
                        paramDirection, paramName.Substring(1), pType);
                }
            }

            SetSqlCommand(SqlCommandType.UpdateCommand, storedProcName);
            AddSqlParameter(SqlCommandType.UpdateCommand, "@actionID", SqlDbType.Char, 6, "UPDATE");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    string pType = GetSqlDbTypeName(paramNames[i], out paramName);
                    paramDirection = paramName[0] != '@' ? ParameterDirection.InputOutput : ParameterDirection.Input;
                    paramName = paramName[0] != '@' ? paramName.Substring(paramName.IndexOf("@")) : paramName;

                    AddSqlParameter(SqlCommandType.UpdateCommand, paramName,
                        paramDirection, paramName.Substring(1), pType);
                }
            }

            SetSqlCommand(SqlCommandType.DeleteCommand, storedProcName);
            AddSqlParameter(SqlCommandType.DeleteCommand, "@actionID", SqlDbType.Char, 6, "DELETE");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    string pType = GetSqlDbTypeName(paramNames[i], out paramName);
                    paramDirection = paramName[0] != '@' ? ParameterDirection.InputOutput : ParameterDirection.Input;
                    paramName = paramName[0] != '@' ? paramName.Substring(paramName.IndexOf("@")) : paramName;

                    AddSqlParameter(SqlCommandType.DeleteCommand, paramName,
                        paramDirection, paramName.Substring(1), pType);
                }
            }

            boolData = UpdateData(changedDS, tableName, useTransaction);
            return boolData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="realParamName"></param>
        /// <returns></returns>
        private string GetSqlDbTypeName(string paramName, out string realParamName)
        {
            realParamName = paramName;
            string sqlDbTypeName = string.Empty;
            int count = Regex.Matches(Regex.Escape(paramName), "@").Count;
            if (count == 2)
            {
                realParamName = paramName.Substring(0, paramName.LastIndexOf('@'));
                sqlDbTypeName = paramName.Substring(paramName.LastIndexOf('@') + 1);
            }

            return sqlDbTypeName;
        }

        /// <summary>
        /// Update multi-rows to database
        /// </summary>
        /// <param name="changedDS"></param>
        /// <param name="storedProcName"></param>
        /// <param name="paramNames"></param>
        /// <param name="tableName"></param>
        /// <param name="useTransaction"></param>
        /// <returns></returns>
        public bool ExecuteUpdateData(DataSet changedDS, string storedProcName, string[] paramNames, string tableName, bool useTransaction)
        {
            SetSqlCommand(SqlCommandType.InsertCommand, storedProcName);
            AddSqlParameter(SqlCommandType.InsertCommand, "@actionID", SqlDbType.Char, 6, "INSERT");

            string paramName = string.Empty;
            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    paramName = paramNames[i];
                    AddSqlParameter(SqlCommandType.InsertCommand, paramName,
                        ParameterDirection.Input, paramName.Substring(1));
                }
            }

            SetSqlCommand(SqlCommandType.UpdateCommand, storedProcName);
            AddSqlParameter(SqlCommandType.UpdateCommand, "@actionID", SqlDbType.Char, 6, "UPDATE");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    paramName = paramNames[i];
                    AddSqlParameter(SqlCommandType.UpdateCommand, paramName,
                        ParameterDirection.Input, paramName.Substring(1));
                }
            }

            SetSqlCommand(SqlCommandType.DeleteCommand, storedProcName);
            AddSqlParameter(SqlCommandType.DeleteCommand, "@actionID", SqlDbType.Char, 6, "DELETE");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    paramName = paramNames[i];
                    AddSqlParameter(SqlCommandType.DeleteCommand, paramName,
                        ParameterDirection.Input, paramName.Substring(1));
                }
            }

            return UpdateData(changedDS, tableName, useTransaction);
        }

        /// <summary>
        ///	
        /// </summary>
        public bool ExecuteUpdateData(DataSet changedDS, string storedProcName, string[] paramNames, string[] paramTypes, int[] paramSizes, string tableName, bool useTransaction)
        {
            SetSqlCommand(SqlCommandType.InsertCommand, storedProcName);
            AddSqlParameter(SqlCommandType.InsertCommand, "@actionID", SqlDbType.Char, 6, "INSERT");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    AddSqlParameter(SqlCommandType.InsertCommand, paramNames[i], GetParamTypeByName(paramTypes[i]), paramSizes[i],
                        ParameterDirection.Input, (((string)paramNames[i])).Substring(1));
                }
            }

            SetSqlCommand(SqlCommandType.UpdateCommand, storedProcName);
            AddSqlParameter(SqlCommandType.UpdateCommand, "@actionID", SqlDbType.Char, 6, "UPDATE");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    AddSqlParameter(SqlCommandType.UpdateCommand, paramNames[i], GetParamTypeByName(paramTypes[i]), paramSizes[i],
                        ParameterDirection.Input, ((string)paramNames[i]).Substring(1));
                }
            }

            SetSqlCommand(SqlCommandType.DeleteCommand, storedProcName);
            AddSqlParameter(SqlCommandType.DeleteCommand, "@actionID", SqlDbType.Char, 6, "DELETE");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    AddSqlParameter(SqlCommandType.DeleteCommand, paramNames[i], GetParamTypeByName(paramTypes[i]), paramSizes[i],
                        ParameterDirection.Input, ((string)paramNames[i]).Substring(1));
                }
            }

            return UpdateData(changedDS, tableName, useTransaction);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramTypeName"></param>
        /// <returns></returns>
        private SqlDbType GetParamTypeByName(string paramTypeName)
        {
            switch (paramTypeName.ToLower())
            {
                case "varchar":
                    return SqlDbType.VarChar;
                case "char":
                    return SqlDbType.Char;
                case "bit":
                    return SqlDbType.Bit;
                case "decimal":
                    return SqlDbType.Decimal;
                case "numeric":
                case "integer":
                    return SqlDbType.Float;
                case "float":
                case "double":
                    return SqlDbType.Float;
                case "bigint":
                    return SqlDbType.BigInt;
                case "binary":
                    return SqlDbType.Binary;
                case "image":
                    return SqlDbType.Image;
                case "int":
                    return SqlDbType.Int;
                case "money":
                    return SqlDbType.Money;
                case "nchar":
                    return SqlDbType.NChar;
                case "ntext":
                    return SqlDbType.NText;
                case "nvarchar":
                    return SqlDbType.NVarChar;
                case "real":
                    return SqlDbType.Real;
                case "smalldatetime":
                    return SqlDbType.SmallDateTime;
                case "datetime":
                case "date":
                    return SqlDbType.DateTime;
                case "smallint":
                    return SqlDbType.SmallInt;
                case "smallmoney":
                    return SqlDbType.SmallMoney;
                case "text":
                    return SqlDbType.Text;
                case "timestamp":
                    return SqlDbType.Timestamp;
                case "tinyInt":
                    return SqlDbType.TinyInt;
                case "variant":
                default:
                    return SqlDbType.Variant;
            }
        }

        #endregion

        #region ExecuteUpdateData

        public bool ExecuteUpdateData(DataSet changedDS, string storedProcName, string[] paramNames, string[] paramTypes, int[] paramSizes, string tableName)
        {

            SetSqlCommand(SqlCommandType.InsertCommand, storedProcName);
            AddSqlParameter(SqlCommandType.InsertCommand, "@actionID", SqlDbType.Char, 6, "INSERT");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    AddSqlParameter(SqlCommandType.InsertCommand, paramNames[i], GetParamTypeByName(paramTypes[i]), paramSizes[i],
                        ParameterDirection.Input, (((string)paramNames[i])).Substring(1));
                }
            }

            SetSqlCommand(SqlCommandType.UpdateCommand, storedProcName);
            AddSqlParameter(SqlCommandType.UpdateCommand, "@actionID", SqlDbType.Char, 6, "UPDATE");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    AddSqlParameter(SqlCommandType.UpdateCommand, paramNames[i], GetParamTypeByName(paramTypes[i]), paramSizes[i],
                        ParameterDirection.Input, ((string)paramNames[i]).Substring(1));
                }
            }

            SetSqlCommand(SqlCommandType.DeleteCommand, storedProcName);
            AddSqlParameter(SqlCommandType.DeleteCommand, "@actionID", SqlDbType.Char, 6, "DELETE");

            if (paramNames != null)
            {
                for (int i = 0; i < paramNames.Length; i++)
                {
                    AddSqlParameter(SqlCommandType.DeleteCommand, paramNames[i], GetParamTypeByName(paramTypes[i]), paramSizes[i],
                        ParameterDirection.Input, ((string)paramNames[i]).Substring(1));
                }
            }

            return UpdateData(changedDS, tableName, false);
        }

        #endregion

        #region Helper Functions

        /// <summary>
        /// Start a new transaction
        /// </summary>
        /// <returns></returns>
        public SqlTransaction BeginTransaction()
        {
            SqlTransaction trans = null;
            int connTimes = CONN_TIMES + 2;

            while (connTimes > 0)
            {
                try
                {
                    if (_connection.State == ConnectionState.Closed)
                    {
                        _connection.Open();
                    }

                    trans = _connection.BeginTransaction();
                    break;
                }
                catch// (System.Exception ex)
                {
                    if (_connection != null)
                    {
                        if (_connection.State == ConnectionState.Open)
                        {
                            _connection.Close();
                        }
                    }
                    connTimes--;
                    System.Threading.Thread.Sleep(INTERVAL_SCHEDULE);
                }
            }

            return trans;
        }


        public T ExecuteQuerySingle<T>(string commandText, string[] paramNames, object[] paramValues)
        {
            var dr = ExecuteQueryDataRow(commandText, CommandType.Text, paramNames, paramValues);
            return dr.FromDataRow<T>();
        }

        public T ExecuteQuerySingle<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues)
        {
            var dr = ExecuteQueryDataRow(commandText, commandType, paramNames, paramValues);
            return dr.FromDataRow<T>();
        }

        public T ExecuteScalar<T>(string commandText, string[] paramNames, object[] paramValues)
        {
            return (T)ExecuteScalar(commandText, CommandType.StoredProcedure, paramNames, paramValues, null);
        }

        public T ExecuteScalar<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues)
        {
            return (T)ExecuteScalar(commandText, commandType, paramNames, paramValues, null);
        }

        public T ExecuteScalar<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            return (T)ExecuteScalar(commandText, commandType, paramNames, paramValues, trans);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="paramNames"></param>
        /// <param name="paramValues"></param>
        public int ExecuteNonQuery(string commandText, string[] paramNames, object[] paramValues)
        {
            return ExecuteNonQuery(commandText, CommandType.StoredProcedure, paramNames, paramValues, (SqlTransaction)null);
        }

        public int ExecuteNonQuery(string commandText, CommandType commandType, string[] paramNames, object[] paramValues)
        {
            return ExecuteNonQuery(commandText, commandType, paramNames, paramValues, (SqlTransaction)null);
        }

        #region MySql is not implement
        public T ExecuteScalar<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, MySqlTransaction trans)
        {
            throw new NotImplementedException();
        }

        public int ExecuteNonQuery(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, MySqlTransaction trans)
        {
            throw new NotImplementedException();
        }

        
        public MySqlTransaction BeginMySqlTransaction()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteQuery<T>(string commandText, string[] paramNames, object[] paramValues, SqlTransaction trans)
        {
            var ds = ExecuteQuery(commandText, paramNames, paramValues, trans);
            return ds.FromDataSet<T>();
        }
        #endregion
        #endregion
    }
}
