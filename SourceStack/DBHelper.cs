using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SourceStack
{
    class DBHelper
    {
        private const string connectionString = "";
        public IDbConnection GetNewConnection()
        {
            return new SqlConnection();
        }
        public int ExecuteNonQuery(String cmdText)
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

        private  int ExecuteNonQuery(String cmdText, params IDataParameter[] dataParameters)
        {
            using (IDbConnection connection = GetNewConnection()) {
                try {
                    connection.Open();
                    IDbCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = cmdText;
                    for (int i = 0; i < dataParameters.Length; i++) {
                        command.Parameters.Add(dataParameters[i]);

                    }
                    return command.ExecuteNonQuery();
                }
                catch (Exception) {

                    throw;
                }

            }
        }


        public int Insert(string cmdText, params IDataParameter[] dataParameters)
        {
            return ExecuteNonQuery(cmdText,dataParameters);
        }
        public int Delete(string cmdText, params IDataParameter[] dataParameters)
        {
            return ExecuteNonQuery(cmdText, dataParameters);
        }
        public int Update(string cmdText, params IDataParameter[] dataParameters)
        {
            return ExecuteNonQuery(cmdText, dataParameters);
        }
        public int Search(string cmdText, params IDataParameter[] dataParameters)
        {
            return ExecuteNonQuery(cmdText, dataParameters);
        }
    }
}
