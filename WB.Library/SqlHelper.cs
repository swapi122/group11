//===============================================================================
// This file is based on the Microsoft Data Access Application Block for .NET
// For more information please go to 
// http://msdn.microsoft.com/library/en-us/dnbda/html/daab-rm.asp
//===============================================================================

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace WB.Library
{

    /// <summary>
    /// The SqlHelper class is intended to encapsulate high performance, 
    /// scalable best practices for common uses of SqlClient.
    /// </summary>
    public abstract class SqlHelper
    {
        //Database connection strings
        public static readonly string ConnectionStringMember = ConfigurationManager.ConnectionStrings["connectstringMember"].ConnectionString;
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["connectstring"].ConnectionString;
        // Hashtable to store cached parameters 
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());

        /// <summary>
        /// Execute a SqlCommand (that returns no resultset) against the database specified in the connection string 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">a valid connection string for a SqlConnection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>an int representing the number of rows affected by the command</returns>
        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            int val = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return val;
        }

        public static int ExecuteNonQuery(string connectionString, Hashtable commandParameters, CommandType cmdType, string cmdText)
        {
            int val = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return val;
        }

        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText)
        {
            return ExecuteNonQuery(connectionString, cmdType, cmdText, null);
        }

        /// <summary>
        /// Execute a SqlCommand that returns a resultset against the database specified in the connection string 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  SqlDataReader r = ExecuteReader(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">a valid connection string for a SqlConnection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>A SqlDataReader containing the results</returns>
        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectionString);
            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        /// <summary>
        /// Execute a SqlCommand that returns a resultset against the database specified in the connection string 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  DataTable dt = ExecuteDataTable(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">a valid connection string for a SqlConnection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>A DataTable containing the results</returns>
        public static DataTable ExecuteDataTable(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return dt;
        }

        public static DataTable ExecuteDataTable(string connectionString, CommandType cmdType, string cmdText)
        {
            return ExecuteDataTable(connectionString, cmdType, cmdText, null);
        }

        public static DataTable ExecuteDataTable(string connectionString, Hashtable commandParameters, CommandType cmdType, string cmdText)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return dt;
        }

        /*
        public static DataTable ExecuteDataTableByCache(string connectionString, CommandType cmdType, string cmdText, string CacheKey, params SqlParameter[] commandParameters)
        {
            DataTable dt = new DataTable();

            object cachedObject = CachingHelper.GetCacheObject(CacheKey);
            if (cachedObject != null)
            {
                dt = (DataTable)cachedObject;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    CachingHelper.SetSqlCacheDataTable(CacheKey, dt, cmd); // Save Cache DataTable to CacheKey

                    da.Dispose();
                    cmd.Parameters.Clear();
                    conn.Close();
                }
            }

            return dt;
        }
        */

        /// <summary>
        /// Execute a SqlCommand that returns a resultset against the database specified in the connection string 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  DataTable dt = ExecuteDataTable(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">a valid connection string for a SqlConnection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>A DataTable containing the results</returns>
        public static DataSet ExecuteDataSet(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return ds;
        }

        public static DataSet ExecuteDataSet(string connectionString, Hashtable commandParameters, CommandType cmdType, string cmdText)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return ds;
        }

        public static DataSet ExecuteDataSet(string connectionString, CommandType cmdType, string cmdText)
        {
            return ExecuteDataSet(connectionString, cmdType, cmdText, null);
        }

        /// <summary>
        /// Execute a SqlCommand that returns the first column of the first record against the database specified in the connection string 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">a valid connection string for a SqlConnection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>An object that should be converted to the expected type using Convert.To{Type}</returns>
        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            object val;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
            }
            return val;
        }

        /// <summary>
        /// add parameter array to the cache
        /// </summary>
        /// <param name="cacheKey">Key to the parameter cache</param>
        /// <param name="cmdParms">an array of SqlParamters to be cached</param>
        public static void CacheParameters(string cacheKey, params SqlParameter[] commandParameters)
        {
            parmCache[cacheKey] = commandParameters;
        }

        /// <summary>
        /// Retrieve cached parameters
        /// </summary>
        /// <param name="cacheKey">key used to lookup parameters</param>
        /// <returns>Cached SqlParamters array</returns>
        public static SqlParameter[] GetCachedParameters(string cacheKey)
        {
            SqlParameter[] cachedParms = (SqlParameter[])parmCache[cacheKey];

            if (cachedParms == null)
                return null;

            SqlParameter[] clonedParms = new SqlParameter[cachedParms.Length];

            for (int i = 0, j = cachedParms.Length; i < j; i++)
                clonedParms[i] = (SqlParameter)((ICloneable)cachedParms[i]).Clone();

            return clonedParms;
        }

        /// <summary>
        /// Prepare a command for execution
        /// </summary>
        /// <param name="cmd">SqlCommand object</param>
        /// <param name="conn">SqlConnection object</param>
        /// <param name="trans">SqlTransaction object</param>
        /// <param name="cmdType">Cmd type e.g. stored procedure or text</param>
        /// <param name="cmdText">Command text, e.g. Select * from Products</param>
        /// <param name="cmdParms">SqlParameters to use in the command</param>
        public static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        /// <summary>
        /// Prepare a command for execution
        /// </summary>
        /// <param name="cmd">SqlCommand object</param>
        /// <param name="conn">SqlConnection object</param>
        /// <param name="trans">SqlTransaction object</param>
        /// <param name="cmdType">Cmd type e.g. stored procedure or text</param>
        /// <param name="cmdText">Command text, e.g. Select * from Products</param>
        /// <param name="cmdParms">Hastable parameter to use in the command</param>
        public static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, Hashtable cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (DictionaryEntry en in cmdParms)
                {
                    SqlParameter para = new SqlParameter("@" + en.Key, en.Value);
                    cmd.Parameters.Add(para);
                }
            }
        }
        public static bool IsNumbericDataType(String dataType)
        {
            dataType = dataType.ToLower();
            switch (dataType)
            { 
                case "int":
                case "float":
                case "bit":
                case "money":
                case "smallmoney":
                case "tinyint":
                case "smallint":
                case "bigint":
                case "decimal":
                case "numeric":
                case "real":
                    return true;
                default:
                    return false;
            }
        }
        public static bool IsUnicodeDataType(String dataType)
        {
            dataType = dataType.ToLower();
            switch (dataType)
            {
                case "nvarchar":
                case "nchar":
                case "ntext":              
                    return true;
                default:
                    return false;
            }
        }
    }
}
