using System;
using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Data;

namespace RoaSystems.Data
{
    public class DataContext : IDataContext
    {
        private readonly IDbConnection _connection;
        private IDbTransaction _transaction;

        public DataContext(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
        }

        public IDbConnection Connection
        {
            get { return _connection; }
        }

        /// <summary>
        /// Begin a database transaction.
        /// </summary>
        public void BeginTransaction()
        {
            Open();
            _transaction = _connection.BeginTransaction();
        }

        /// <summary>
        /// Open the database connection.
        /// </summary>
        public void Open()
        {
            if (_connection.State != ConnectionState.Open) _connection.Open();
        }

        /// <summary>
        /// Close the database connection and free the resources.
        /// </summary>
        public void Close()
        {
            if (_connection.State != ConnectionState.Closed) _connection.Close();
            _connection.Dispose();
        }

        /// <summary>
        /// Commit the database transaction.
        /// </summary>
        public void Commit()
        {
            if (_transaction == null) throw new ApplicationException("Transaction is not initialized.");
            _transaction.Commit();
        }

        /// <summary>
        /// Rollback the database transaction.
        /// </summary>
        public void Rollback()
        {
            if (_transaction == null) throw new ApplicationException("Transaction is not initialized.");
            _transaction.Rollback();
        }

        /// <summary>
        /// Execute a Sql command that does not return a resultset.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Rows affected</returns>
        public int Execute(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30)
        {
            using (var cmd = BuildCommand(command, commandType, parameterList, timeout))
            {
                Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Execute a Sql command and return the results in a dataset.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Results of the Sql command in a dataset</returns>
        public DataSet ExecuteDataSet(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30)
        {
            using (var cmd = BuildCommand(command, commandType, parameterList, timeout))
            {
                Open();
                var adapter = new MySqlDataAdapter { SelectCommand = cmd };
                var ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }

        /// <summary>
        /// Execute a Sql command and return the results in a dataset.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Results of the Sql command in a datatable</returns>
        public DataTable ExecuteDataTable(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 130)
        {
            // 4-12-2010 ML Increased timeout from 30 to 130

            using (var cmd = BuildCommand(command, commandType, parameterList, timeout))
            {
                Open();
                var adapter = new MySqlDataAdapter { SelectCommand = cmd };
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        /// <summary>
        /// Execute a Sql command and return the results in a datareader.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="behavior">The command behavior value</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Results of a Sql command in a datareader</returns>
        public MySqlDataReader ExecuteDataReader(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30,
            CommandBehavior behavior = CommandBehavior.Default)
        {
            //  Acts as a nolock on all reads
            if (commandType == CommandType.Text)
            {
                command = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + command;
            }
            using (var cmd = BuildCommand(command, commandType, parameterList, timeout))
            {
                Open();
                var startTime = DateTime.Now;
                var reader = cmd.ExecuteReader(behavior);
                LogCommand(command, startTime, parameterList);
                return reader;
            }
        }

        protected virtual void LogCommand(string sql, DateTime startTime, List<MySqlParameter> parameterList)
        {
        }

        /// <summary>
        /// Execute a Sql command that returns a one row, one column result.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Result of the Sql command</returns>
        public object ExecuteScalar(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30)
        {
            using (var cmd = BuildCommand(command, commandType, parameterList, timeout))
            {
                Open();
                return cmd.ExecuteScalar();
            }
        }


        /// <summary>
        /// Execute a Sql command and return the results in an XML reader.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Results of a Sql command in an XML reader</returns>
        public System.Xml.XmlReader ExecuteXmlReader(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30)
        {
            throw new Exception("Not implemented");
            //using (var cmd = BuildCommand(command, commandType, parameterList, timeout))
            //{
            //    Open();
            //    return cmd.ExecuteXmlReader();
            //}
        }

        /// <summary>
        /// Construct a Sql Command object.
        /// </summary>
        /// <param name="command">The Sql command to be executed</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout"></param>
        private MySqlCommand BuildCommand(string command, CommandType commandType, List<MySqlParameter> parameterList, int timeout)
        {
            var cmd = new MySqlCommand()
            {
                Connection = (_connection as MySqlConnection),
                Transaction = (_transaction as MySqlTransaction),
                CommandText = command,
                CommandType = commandType,
                CommandTimeout = timeout
            };
            if (parameterList != null && parameterList.Any())
                cmd.Parameters.AddRange(parameterList.ToArray());

            return cmd;
        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Dispose();

            if (_connection.State != ConnectionState.Closed)
                _connection.Close();

            _connection.Dispose();
        }
    }
}