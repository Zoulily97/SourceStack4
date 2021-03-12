using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace SourceStack
{
    class DBHelper
    {
        private const string connectionString = @" Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YQBang4;Integrated Security=True;";
        

        public IDbConnection GetNewConnection()
        {
            return new SqlConnection(connectionString);
        }
        private int executeNonQuery(string cmdText, params IDataParameter[] dataParameters)
        {
            IDbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            for (int i = 0; i < dataParameters.Length; i++) {
                command.Parameters.Add(dataParameters[i]);
            }
            return executeNonQuery(command);
        }
        public int executeNonQuery(IDbCommand command)
        {
            using (IDbConnection connection = GetNewConnection()) {
                connection.Open();
                command.Connection = connection;
                return command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 非参数化ExecuteNonQuery
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string cmdText)
        {
            using (IDbConnection connection = GetNewConnection()) {
                try {
                    connection.Open();
                    IDbCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = cmdText;
                    return command.ExecuteNonQuery();
                }
                catch (Exception) {

                    throw;
                }

            }
        }
        public int Insert(string cmdText, params IDataParameter[] dataParameters)
        {
            return executeNonQuery(cmdText, dataParameters);
        }
        public int Delete(string cmdText, params IDataParameter[] dataParameters)
        {
            return executeNonQuery(cmdText, dataParameters);
        }
        /// <summary>
        /// 执行多个comandsDeleteRange
        /// </summary>
        /// <param name="commands"></param>
        public void DeleteRange(IDbCommand[] commands)
        {
            using (IDbConnection connection = GetNewConnection()) {
                connection.Open();
                for (int i = 0; i < commands.Length; i++) {
                    commands[i].Connection = connection;
                    commands[i].ExecuteNonQuery();
                }

            }
        }
        public void DeleteRange(string cmdText, params IDataParameter[] dataParameters)
        {
            IDbCommand[] commands = new SqlCommand[dataParameters.Length];
            for (int i = 0; i < dataParameters.Length; i++) {
                commands[i] = new SqlCommand {
                    CommandText = cmdText
                };
                commands[i].Parameters.Add(dataParameters[i]);
            }
            DeleteRange(commands);
        }

        public int Update(string cmdText, params IDataParameter[] dataParameters)
        {
            return executeNonQuery(cmdText, dataParameters);
        }

        internal DbDataReader ExecuteReader(string cmdText, params IDataParameter[] dataParameters)
        {

            using (IDbConnection connection = GetNewConnection()) {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = cmdText;
                for (int i = 0; i < dataParameters.Length; i++) {
                    command.Parameters.Add(dataParameters[i]);
                }
                DbDataReader reader = (DbDataReader)command.ExecuteReader();
                return reader;
            }
        }

       


    }
}
