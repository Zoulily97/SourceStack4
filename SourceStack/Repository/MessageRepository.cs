using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class MessageRepository
    {
        private static IList<Message> messages;
        static MessageRepository()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="onlyNotRead">可选参数，不写false</param>
        /// <returns></returns>
        public IList<Message> GetMine(bool onlyNotRead = false)
        {
            messages = new List<Message>();
            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            using (IDbConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select * from Message";
                DbDataReader reader = (DbDataReader)command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        Message message = new Message {
                            Content = (string)reader["Content"],
                            Id = (int)reader["ID"],
                            CreateTime=(DateTime)reader["CreateTime"],
                            //HasRead = (bool)reader["HasRead"],
                            //Selected=(bool)reader["Selected"]
                        };
                        messages.Add(message);
                    }
                }
            }
            

            var result = messages;
            if (onlyNotRead) {
                //  return messages.Where(m => !m.HasRead).ToList();
                result = messages.Where(m => !m.HasRead).ToList();//未读的
            }

            //else {
            //    return messages; //返回所有的
            //}
            //else nothig
            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Message Find(int id)
        {
            // messages = new List<Message>();
            Message message = new Message();
            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            using (IDbConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select * from Message where id={id}";
                DbDataReader reader = (DbDataReader)command.ExecuteReader();
                    if (reader.Read()) {
                    message.Content = (string)reader["Content"];
                    message.Id = (int)reader["ID"];
                    message.CreateTime = (DateTime)reader["CreateTime"];
                    //message.Selected = (bool)reader["Selected"];
                    //message.HasRead = (bool)reader["HasRead"];

                }
            }
            return message;
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}
