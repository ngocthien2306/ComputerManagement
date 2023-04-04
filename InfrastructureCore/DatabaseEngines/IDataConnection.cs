using InfrastructureCore.DatabaseEngines.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureCore.DatabaseEngines
{
    public interface IDataConnection: IDisposable
    {
        SqlTransaction BeginTransaction();
        MySqlTransaction BeginMySqlTransaction();
        DataSet ExecuteQuery(string commandText, string[] paramNames, object[] paramValues);
        DataSet ExecuteQuery(string commandText, CommandType commandType, string[] paramNames, object[] paramValues);
        Task<IEnumerable<T>> ExecuteQueryAsync<T>(string commandText, string[] paramNames, object[] paramValues);
        Task<IEnumerable<T>> ExecuteQueryAsync<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues);
        IEnumerable<T> ExecuteQuery<T>(string commandText, string[] paramNames, object[] paramValues);
        IEnumerable<T> ExecuteQuery<T>(string commandText, string[] paramNames, object[] paramValues, SqlTransaction trans);
        List<List<MapFieldDBModel>> ExecuteQuery2(string commandText, string[] paramNames, object[] paramValues);



        IEnumerable<T> ExecuteQuery<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues);
        T ExecuteQuerySingle<T>(string commandText, string[] paramNames, object[] paramValues);
        T ExecuteQuerySingle<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues);
        T ExecuteScalar<T>(string commandText, string[] paramNames, object[] paramValues);
        T ExecuteScalar<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues);
        T ExecuteScalar<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, SqlTransaction trans);
        T ExecuteScalar<T>(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, MySqlTransaction trans);
        int ExecuteNonQuery(string commandText, string[] paramNames, object[] paramValues);
        int ExecuteNonQuery(string commandText, CommandType commandType, string[] paramNames, object[] paramValues);
        int ExecuteNonQuery(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, SqlTransaction trans);
        int ExecuteNonQuery(string commandText, CommandType commandType, string[] paramNames, object[] paramValues, MySqlTransaction trans);
        bool ExecuteUpdateData(DataSet changedDS, string storedProcName, string[] paramNames, string[] paramTypes, int[] paramSizes, string tableName);

    }
}
