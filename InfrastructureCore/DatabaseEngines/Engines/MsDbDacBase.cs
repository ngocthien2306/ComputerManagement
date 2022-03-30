using InfrastructureCore.DatabaseEngines.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureCore.DatabaseEngines.Engines
{
    public class MsDbDacBase : IDisposable
    {
        #region Privates


        private string strLogLevel = string.Empty;


        private SqlDataAdapter daCMAX = new SqlDataAdapter();

        public SqlCommand loadCommand;
        public SqlCommand insertCommand;
        public SqlCommand updateCommand;
        public SqlCommand deleteCommand;

        protected SqlConnection _connection;
        public string ConnectionString
        {
            get
            {
                return _connection != null ? _connection.ConnectionString : string.Empty;
            }
        }

        #endregion Privates

        #region Constructors

        public MsDbDacBase() : this(string.Empty)
        {
        }


        void _connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            
        }


        public MsDbDacBase(string connectionString)
        {
            try
            {
                _connection = new SqlConnection(connectionString);
                _connection.InfoMessage += _connection_InfoMessage;

                daCMAX = new SqlDataAdapter();

                /// 
                /// default to korea
                /// Fix load language
                //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ko-KR");
                //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ko-KR");
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
        }

        /// <summary>
        ///     Dispose of this object's resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true); // as a service to those who might inherit from us
        }


        #endregion

        #region Protected

        #region Disposing

        /// <summary>
        ///		Free the instance variables of this object.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
                return; // we're being collected, so let the GC take care of this object

            if (loadCommand != null)
            {
                if (loadCommand.Connection != null)
                {
                    loadCommand.Parameters.Clear();
                    loadCommand.Connection.Dispose();
                }
                loadCommand.Dispose();
            }

            if (insertCommand != null)
            {
                insertCommand.Parameters.Clear();
                insertCommand.Dispose();
            }

            if (updateCommand != null)
            {
                updateCommand.Parameters.Clear();
                updateCommand.Dispose();
            }

            if (deleteCommand != null)
            {
                deleteCommand.Parameters.Clear();
                deleteCommand.Dispose();
            }

            if (_connection != null)
                _connection.Dispose();

            if (daCMAX != null)
            {
                daCMAX.Dispose();
                daCMAX = null;
            }
        }

        #endregion

        #region AddSqlParameter
        /// <summary>
        /// Add a Sql parameter to Sql command, setting by SetSqlCommand
        /// </summary>
        /// <param name="sqlCmdType"></param>
        /// <param name="paramName"></param>
        /// <param name="paramDirection"></param>
        /// <param name="sourceColumn"></param>
        /// <param name="sqlDbTypeName"></param>
        /// <returns></returns>
        protected SqlParameter AddSqlParameter(SqlCommandType sqlCmdType, string paramName,
            ParameterDirection paramDirection, string sourceColumn, SqlDbType sqlDbTypeName)

        {
            SqlParameter parm = null;
            try
            {
                parm = new SqlParameter();
                parm.ParameterName = paramName;
                parm.SourceColumn = sourceColumn;
                parm.Direction = paramDirection;
                parm.SqlDbType = sqlDbTypeName;

                switch (sqlCmdType)
                {
                    case SqlCommandType.SelectCommand:
                        if (loadCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        loadCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.InsertCommand:
                        if (insertCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        insertCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.UpdateCommand:
                        if (updateCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        updateCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.DeleteCommand:
                        if (deleteCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        deleteCommand.Parameters.Add(parm);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {

            }

            return parm;
        }

        /// <summary>
        /// Add a SqlParameter to Sql command indicated by sqlCmdType
        /// </summary>
        /// <param name="sqlCmdType"></param>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        protected SqlParameter AddSqlParameter(SqlCommandType sqlCmdType, string paramName, object paramValue)
        {
            SqlParameter parm = null;
            try
            {
                parm = new SqlParameter(paramName, paramValue);
                parm.Direction = ParameterDirection.Input;

                switch (sqlCmdType)
                {
                    case SqlCommandType.SelectCommand:
                        if (loadCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        loadCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.InsertCommand:
                        if (insertCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        insertCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.UpdateCommand:
                        if (updateCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        updateCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.DeleteCommand:
                        if (deleteCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        deleteCommand.Parameters.Add(parm);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {

            }

            return parm;
        }

        /// <summary>
        /// Add a Sql parameter to Sql command, setting by SetSqlCommand
        /// </summary>
        /// <param name="sqlCmdType"></param>
        /// <param name="paramName"></param>
        /// <param name="paramType"></param>
        /// <param name="paramSize"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        protected SqlParameter AddSqlParameter(SqlCommandType sqlCmdType, string paramName, SqlDbType paramType, int paramSize, object paramValue)
        {
            return AddSqlParameter(sqlCmdType, paramName, paramType, paramSize, paramValue, ParameterDirection.Input);
        }

        /// <summary>
        /// Add a Sql parameter to Sql command, setting by SetSqlCommand
        /// </summary>
        /// <param name="sqlCmdType"></param>
        /// <param name="paramName"></param>
        /// <param name="paramType"></param>
        /// <param name="paramSize"></param>
        /// <param name="paramValue"></param>
        /// <param name="paramDirection"></param>
        /// <returns></returns>
        protected SqlParameter AddSqlParameter(SqlCommandType sqlCmdType, string paramName, SqlDbType paramType, int paramSize, object paramValue, ParameterDirection paramDirection)
        {
            SqlParameter parm = null;
            try
            {
                parm = new SqlParameter(paramName, paramType, paramSize);
                parm.Direction = paramDirection;
                parm.Value = paramValue;

                switch (sqlCmdType)
                {
                    case SqlCommandType.SelectCommand:
                        if (loadCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        loadCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.InsertCommand:
                        if (insertCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        insertCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.UpdateCommand:
                        if (updateCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        updateCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.DeleteCommand:
                        if (deleteCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        deleteCommand.Parameters.Add(parm);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {

            }

            return parm;

        }

        ///// <summary>
        ///// Add a Sql parameter to Sql command, setting by SetSqlCommand
        ///// </summary>
        ///// <param name="sqlCmdType"></param>
        ///// <param name="paramName"></param>
        ///// <param name="paramType"></param>
        ///// <param name="paramSize"></param>
        ///// <param name="sourceColumn"></param>
        ///// <returns></returns>
        //protected SqlParameter AddSqlParameter(SqlCommandType sqlCmdType, string paramName, SqlDbType paramType, int paramSize, string sourceColumn)
        //{
        //    return AddSqlParameter(sqlCmdType, paramName, paramType, paramSize, sourceColumn, ParameterDirection.Input);
        //}

        /// <summary>
        /// Add a Sql parameter to Sql command, setting by SetSqlCommand
        /// </summary>
        /// <param name="sqlCmdType"></param>
        /// <param name="paramName"></param>
        /// <param name="paramDirection"></param>
        /// <param name="sourceColumn"></param>
        /// <returns></returns>
        protected SqlParameter AddSqlParameter(SqlCommandType sqlCmdType, string paramName,
            ParameterDirection paramDirection, string sourceColumn)
        {
            return AddSqlParameter(sqlCmdType, paramName, paramDirection, sourceColumn, string.Empty);
        }

        /// <summary>
        /// Add a Sql parameter to Sql command, setting by SetSqlCommand
        /// </summary>
        /// <param name="sqlCmdType"></param>
        /// <param name="paramName"></param>
        /// <param name="paramDirection"></param>
        /// <param name="sourceColumn"></param>
        /// <returns></returns>
        protected SqlParameter AddSqlParameter(SqlCommandType sqlCmdType, string paramName,
            ParameterDirection paramDirection, string sourceColumn, string sqlDbTypeName)

        {
            SqlParameter parm = null;
            try
            {
                parm = new SqlParameter();
                parm.ParameterName = paramName;
                parm.SourceColumn = sourceColumn;
                parm.Direction = paramDirection;
                if (!string.IsNullOrEmpty(sqlDbTypeName))
                {
                    parm.SqlDbType = (SqlDbType)Enum.Parse(typeof(SqlDbType), sqlDbTypeName);
                }

                switch (sqlCmdType)
                {
                    case SqlCommandType.SelectCommand:
                        if (loadCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        loadCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.InsertCommand:
                        if (insertCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        insertCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.UpdateCommand:
                        if (updateCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        updateCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.DeleteCommand:
                        if (deleteCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        deleteCommand.Parameters.Add(parm);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {

            }

            return parm;
        }

        /// <summary>
        /// Add a Sql parameter to Sql command, setting by SetSqlCommand
        /// </summary>
        /// <param name="sqlCmdType"></param>
        /// <param name="paramName"></param>
        /// <param name="paramType"></param>
        /// <param name="paramSize"></param>
        /// <param name="sourceColumn"></param>
        /// <param name="paramDirection"></param>
        /// <returns></returns>
        protected SqlParameter AddSqlParameter(SqlCommandType sqlCmdType, string paramName, SqlDbType paramType, int paramSize, ParameterDirection paramDirection, string sourceColumn)
        {
            SqlParameter parm = null;
            try
            {
                parm = new SqlParameter(paramName, paramType, paramSize, sourceColumn);
                parm.Direction = paramDirection;

                switch (sqlCmdType)
                {
                    case SqlCommandType.SelectCommand:
                        if (loadCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        loadCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.InsertCommand:
                        if (insertCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        insertCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.UpdateCommand:
                        if (updateCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        updateCommand.Parameters.Add(parm);
                        break;

                    case SqlCommandType.DeleteCommand:
                        if (deleteCommand == null) throw new Exception("You must use SetSqlCommand first.");
                        deleteCommand.Parameters.Add(parm);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {

            }

            return parm;
        }

        #endregion AddSqlParameter

        #region SetSqlCommand

        /// <summary>
        /// Create SqlCommand, default CommandType is StoredProcedure
        /// </summary>
        /// <param name="commandText"></param>
        protected void SetSqlCommand(SqlCommandType sqlCmdType, string commandText)
        {
            SetSqlCommand(sqlCmdType, commandText, CommandType.StoredProcedure);
        }

        /// <summary>
        /// Create SqlCommand, providing commandType
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="commandType"></param>
        /// <param name="parms"></param>
        protected void SetSqlCommand(SqlCommandType sqlCmdType, string commandText, CommandType commandType)
        {
            try
            {
                switch (sqlCmdType)
                {
                    case SqlCommandType.SelectCommand:
                        loadCommand = new SqlCommand(commandText, _connection);
                        loadCommand.CommandType = commandType;
                        break;
                    case SqlCommandType.InsertCommand:
                        insertCommand = new SqlCommand(commandText, _connection);
                        insertCommand.CommandType = commandType;
                        break;
                    case SqlCommandType.UpdateCommand:
                        updateCommand = new SqlCommand(commandText, _connection);
                        updateCommand.CommandType = commandType;
                        break;
                    case SqlCommandType.DeleteCommand:
                        deleteCommand = new SqlCommand(commandText, _connection);
                        deleteCommand.CommandType = commandType;
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {

            }
        }

        #endregion SetSqlCommand

        #endregion Protected

        #region Public members

        #region Functions

        #region ExecuteFill

        /// <summary>
        /// Return DataSet based on Settings by SetSqlCommand statement
        /// </summary>
        /// <returns></returns>
        protected DataSet ExecuteFill()
        {
            return ExecuteFill(false);
        }
        protected async Task<DataSet> ExecuteFillAsync()
        {
            return await ExecuteFillAsync(false);
        }
        /// <summary>
        /// Return DataSet based on Settings by SetSqlCommand statement
        /// </summary>
        /// <returns></returns>
        protected DataSet ExecuteFill(bool includeSchema)
        {
            DataSet dsResult = null;

            try
            {
                dsResult = new DataSet();
                daCMAX.SelectCommand = loadCommand;
                if (includeSchema)
                    daCMAX.FillSchema(dsResult, SchemaType.Source);
                daCMAX.Fill(dsResult);
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);

            }
            finally
            {

            }

            return dsResult;
        }
        protected async Task<DataSet> ExecuteFillAsync(bool includeSchema)
        {
            DataSet dsResult = null;

            try
            {
                dsResult = new DataSet();
                daCMAX.SelectCommand = loadCommand;
                if (includeSchema)
                    daCMAX.FillSchema(dsResult, SchemaType.Source);
                await Task.Run(() => daCMAX.Fill(dsResult));
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);

            }
            finally
            {

            }

            return dsResult;
        }


        #endregion ExecuteFill

        #region WebPageExecuteFill
        /// <summary>
        /// Web¿¡¼­ PageÀ» À§ÇØ¼­ DataSet¸¦ ¸®ÅÏ¹Þ´Â ExecuteFill(µ¥ÀÌÅ¸ ¾òÀ»¶§ ÀÌ¿ëµÈ´Ù.) 
        /// </summary>
        /// <param name="commandText">½ºÅä¾îµå ÇÁ·Î½ÃÀú¸í</param>
        /// <param name="sqlParameter">SqlParameter Array</param>
        /// <param name="intPageSize">PageSize</param>
        /// <param name="intPageIndex">PageIndex</param>
        /// <returns>DataSetÀ¸·Î °á°ú¸¦ ¹Þ´Â´Ù.</returns>
        protected DataSet WebPageExecuteFill(int intPageSize, int intPageIndex)
        {
            DataSet dsResult = null;

            try
            {
                dsResult = new DataSet();
                daCMAX.SelectCommand = loadCommand;

                if ((intPageSize <= 0) || (intPageIndex <= 0))
                {
                    //					daCMAX.SelectCommand.Parameters.Clear();
                    return dsResult;
                }

                daCMAX.Fill(dsResult, (intPageIndex - 1) * intPageSize, intPageSize, "None");
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {

            }

            return dsResult;

        }
        #endregion ExecuteFill

        #region ExecuteScalar

        /// <summary>
        /// Return single value based on Settings by SetSqlCommand statement
        /// </summary>
        /// <returns></returns>
        protected object ExecuteScalar(bool transactionYN)
        {
            object retValue = null;
            SqlTransaction tr = null;
            try
            {
                if (transactionYN)
                {
                    daCMAX.SelectCommand = loadCommand;
                    if (_connection.State == ConnectionState.Closed)
                    {
                        _connection.Open();
                    }

                    tr = _connection.BeginTransaction();
                    daCMAX.SelectCommand.Transaction = tr;
                    retValue = daCMAX.SelectCommand.ExecuteScalar();

                    tr.Commit();
                }
                else
                {
                    daCMAX.SelectCommand = loadCommand;
                    if (daCMAX.SelectCommand.Connection.State == ConnectionState.Closed) daCMAX.SelectCommand.Connection.Open();
                    retValue = daCMAX.SelectCommand.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
                if (tr != null)
                {
                    tr.Rollback();
                }
            }
            finally
            {
                if (daCMAX.SelectCommand.Connection.State == ConnectionState.Open)
                {
                    daCMAX.SelectCommand.Connection.Close();
                }
                if (tr != null)
                {
                    tr.Dispose();
                }
            }

            return retValue;
        }

        /// <summary>
        /// Return single value based on Settings by SetSqlCommand statement
        /// </summary>
        /// <returns></returns>
        protected object ExecuteScalar(SqlTransaction trans)
        {
            object retValue = null;
            try
            {
                daCMAX.SelectCommand = loadCommand;
                daCMAX.SelectCommand.Transaction = trans;

                if (daCMAX.SelectCommand.Connection.State == ConnectionState.Closed) daCMAX.SelectCommand.Connection.Open();
                retValue = daCMAX.SelectCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {
            }

            return retValue;
            ////// Tuấn modify
            //daCMAX.SelectCommand = loadCommand;
            //    daCMAX.SelectCommand.Transaction = trans;

            //    if (daCMAX.SelectCommand.Connection.State == ConnectionState.Closed) daCMAX.SelectCommand.Connection.Open();
            //    retValue = daCMAX.SelectCommand.ExecuteScalar();


            return retValue;
        }

        #endregion ExecuteScalar

        #region ExecuteNonQuery

        /// <summary>
        /// Processing without return any value, excepts number of row count.
        /// The command is set by SetSqlCommand statement
        /// </summary>
        /// <returns></returns>
        protected int ExecuteNonQuery(bool transactionYN)
        {
            int numberOfRowCount = 0;
            SqlTransaction tr = null;

            try
            {
                if (transactionYN)
                {
                    daCMAX.SelectCommand = loadCommand;
                    if (_connection.State == ConnectionState.Closed)
                    {
                        _connection.Open();
                    }

                    tr = _connection.BeginTransaction();
                    daCMAX.SelectCommand.Transaction = tr;
                    daCMAX.SelectCommand.ExecuteScalar();

                    tr.Commit();
                }
                else
                {
                    daCMAX.SelectCommand = loadCommand;
                    if (daCMAX.SelectCommand.Connection.State == ConnectionState.Closed) daCMAX.SelectCommand.Connection.Open();
                    numberOfRowCount = daCMAX.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);

                if (tr != null)
                {
                    tr.Rollback();
                }
            }
            finally
            {
                if (daCMAX.SelectCommand.Connection.State == ConnectionState.Open)
                    daCMAX.SelectCommand.Connection.Close();

                if (tr != null)
                {
                    tr.Dispose();
                }
            }

            return numberOfRowCount;
        }


        /// <summary>
        /// Execute a nonquery command using transaction
        /// </summary>
        /// <param name="trans"></param>
        /// <returns></returns>
        protected int ExecuteNonQuery(SqlTransaction trans)
        {
            int numberOfRowCount = 0;

            //try
            //{
            //    daCMAX.SelectCommand = loadCommand;
            //    daCMAX.SelectCommand.Transaction = trans;
            //    if (daCMAX.SelectCommand.Connection.State == ConnectionState.Closed) daCMAX.SelectCommand.Connection.Open();
            //    numberOfRowCount = daCMAX.SelectCommand.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    ExceptionHandler.Publish(ex, false);
            //}
            //finally
            //{
            //}
            //tuan change
            daCMAX.SelectCommand = loadCommand;
            daCMAX.SelectCommand.Transaction = trans;
            if (daCMAX.SelectCommand.Connection.State == ConnectionState.Closed) daCMAX.SelectCommand.Connection.Open();
            numberOfRowCount = daCMAX.SelectCommand.ExecuteNonQuery();


            return numberOfRowCount;
        }

        #endregion ExecuteNonQuery

        #region ExecuteReader

        /// <summary>
        /// Return a SqlDataReader object based on settings by SetSqlCommand statement.
        /// Remember to close the SqlDataReader object
        /// </summary>
        /// <returns></returns>
        protected SqlDataReader ExecuteReader()
        {
            SqlDataReader sqlReader = null;

            try
            {
                daCMAX.SelectCommand = loadCommand;
                if (daCMAX.SelectCommand.Connection.State == ConnectionState.Closed) daCMAX.SelectCommand.Connection.Open();
                sqlReader = daCMAX.SelectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                ExceptionHandler.Publish(ex, false);
            }
            finally
            {
            }

            return sqlReader;
        }

        #endregion ExecuteReader

        #region UpdateData

        /// <summary>
        /// Process Insert, Update, Delete once using internal DataAdapter.
        /// The DataSet must contain all columns necessary for Insert, Update, Delete 
        /// command which SourceColumn of each SqlParameter bound to.
        /// </summary>
        /// <param name="dsObject"></param>
        /// <returns>True if OK, False means error occur. Get the error rows by 
        /// dsObject.Tables[0].GetErrors() to get rows having errors</returns>
        protected bool UpdateData(DataSet dsObject, bool transactionYN)
        {
            return UpdateData(dsObject, null, transactionYN);
        }

        /// <summary>
        /// Process Insert, Update, Delete once using internal DataAdapter.
        /// The DataSet must contain all columns necessary for Insert, Update, Delete 
        /// command which SourceColumn of each SqlParameter bound to.
        /// </summary>
        /// <param name="dsObject"></param>
        /// <param name="srcTable"></param>
        /// <param name="transactionYN"></param>
        /// <returns>True if OK, False means error occur. Get the error rows by 
        /// dsObject.Tables[0].GetErrors() to get rows having errors</returns>
        protected bool UpdateData(DataSet dsObject, string srcTable, bool transactionYN)
        {
            return UpdateData2(dsObject, srcTable, transactionYN) != -1;
        }

        /// <summary>
        /// Process Insert, Update, Delete once using internal DataAdapter.
        /// The DataSet must contain all columns necessary for Insert, Update, Delete 
        /// command which SourceColumn of each SqlParameter bound to.
        /// </summary>
        /// <param name="dsObject"></param>
        /// <param name="srcTable"></param>
        /// <param name="transactionYN"></param>
        /// <returns>True if OK, False means error occur. Get the error rows by 
        /// dsObject.Tables[0].GetErrors() to get rows having errors</returns>
        protected int UpdateData2(DataSet dsObject, bool transactionYN)
        {
            return UpdateData2(dsObject, null, transactionYN);
        }

        /// <summary>
        /// Process Insert, Update, Delete once using internal DataAdapter.
        /// The DataSet must contain all columns necessary for Insert, Update, Delete 
        /// command which SourceColumn of each SqlParameter bound to.
        /// </summary>
        /// <param name="dsObject"></param>
        /// <param name="srcTable"></param>
        /// <returns>True if OK, False means error occur. Get the error rows by 
        /// dsObject.Tables[0].GetErrors() to get rows having errors</returns>
        protected int UpdateData2(DataSet dsObject, string srcTable, bool transactionYN)
        {
            int nResult = -1;

            ///
            /// Transaction
            ///
            if (transactionYN)
            {
                SqlTransaction tr = null;

                try
                {
                    if (_connection.State == ConnectionState.Closed)
                    {
                        _connection.Open();
                    }

                    tr = _connection.BeginTransaction();

                    daCMAX.InsertCommand = insertCommand;
                    daCMAX.UpdateCommand = updateCommand;
                    daCMAX.DeleteCommand = deleteCommand;

                    daCMAX.InsertCommand.Transaction = tr;
                    daCMAX.UpdateCommand.Transaction = tr;
                    daCMAX.DeleteCommand.Transaction = tr;

                    if (srcTable != null)
                        nResult = daCMAX.Update(dsObject, srcTable);
                    else
                        nResult = daCMAX.Update(dsObject);

                    //
                    // Check for table errors to see if the update failed.
                    //
                    if (dsObject.HasErrors)
                    {
                        dsObject.Tables[0].GetErrors()[0].ClearErrors();
                    }

                    tr.Commit();

                }
                catch (Exception ex)
                {
                    ExceptionHandler.Publish(ex, false);

                    if (tr != null)
                    {
                        tr.Rollback();
                    }
                }
                finally
                {
                    if (tr != null)
                    {
                        tr.Dispose();
                    }
                }
            }
            else
            {
                try
                {
                    daCMAX.InsertCommand = insertCommand;
                    daCMAX.UpdateCommand = updateCommand;
                    daCMAX.DeleteCommand = deleteCommand;

                    if (srcTable != null)
                        nResult = daCMAX.Update(dsObject, srcTable);
                    else
                        nResult = daCMAX.Update(dsObject);

                    //
                    // Check for table errors to see if the update failed.
                    //
                    if (dsObject.HasErrors)
                    {
                        dsObject.Tables[0].GetErrors()[0].ClearErrors();
                    }
                    else
                    {
                        if (srcTable != null)
                            dsObject.Tables[srcTable].AcceptChanges();
                        else
                            dsObject.AcceptChanges();

                    }
                }
                catch (Exception ex)
                {
                    ExceptionHandler.Publish(ex, false);
                }
                finally
                {

                }
            }

            return nResult;
        }

        #endregion UpdateData

        #region UpdateData - Use Trans

        /// <summary>
        /// Process Insert, Update, Delete once using internal DataAdapter.
        /// The DataSet must contain all columns necessary for Insert, Update, Delete 
        /// command which SourceColumn of each SqlParameter bound to.
        /// </summary>
        /// <param name="dsObject"></param>
        /// <returns>True if OK, False means error occur. Get the error rows by 
        /// dsObject.Tables[0].GetErrors() to get rows having errors</returns>
        

        #endregion UpdateData

        #endregion Functions

        #endregion Public members

    }

    #region Misc Classes

    public enum SqlCommandType
    {
        SelectCommand, InsertCommand, UpdateCommand, DeleteCommand
    }

    #endregion
}
