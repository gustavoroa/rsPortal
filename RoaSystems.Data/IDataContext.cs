using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace RoaSystems.Data
{
    public interface IDataContext : IDisposable
    {
        /// <summary>
        /// The underlying sql connection
        /// </summary>
        System.Data.IDbConnection Connection { get; }

        /// <summary>
        /// Open the database connection.
        /// </summary>
        void Open();

        /// <summary>
        /// Close the database connection and free the resources.
        /// </summary>
        void Close();

        /// <summary>
        /// Begin a database transaction.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Commit the database transaction.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollback the database transaction.
        /// </summary>
        void Rollback();

        /// <summary>
        /// Execute a Sql command that does not return a resultset.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Rows affected</returns>
        int Execute(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30);

        /// <summary>
        /// Execute a Sql command and return the results in a dataset.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Results of the Sql command in a dataset</returns>
        DataSet ExecuteDataSet(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30);

        /// <summary>
        /// Execute a Sql command and return the results in a dataset.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Results of the Sql command in a datatable</returns>
        DataTable ExecuteDataTable(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 130);

        /// <summary>
        /// Execute a Sql command and return the results in a datareader.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="behavior">The command behavior value</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Results of a Sql command in a datareader</returns>
        MySqlDataReader ExecuteDataReader(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30,
            CommandBehavior behavior = CommandBehavior.Default);

        /// <summary>
        /// Execute a Sql command that returns a one row, one column result.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Result of the Sql command</returns>
        object ExecuteScalar(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30);

        /// <summary>
        /// Execute a Sql command and return the results in an XML reader.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="commandType">The type of the Sql command (text, stored procedure, etc.)</param>
        /// <param name="parameterList">A list of SqlParameters</param>
        /// <param name="timeout">The command timeout value</param>
        /// <returns>Results of a Sql command in an XML reader</returns>
        System.Xml.XmlReader ExecuteXmlReader(string command,
            CommandType commandType = CommandType.Text,
            List<MySqlParameter> parameterList = null,
            int timeout = 30);

    }
}