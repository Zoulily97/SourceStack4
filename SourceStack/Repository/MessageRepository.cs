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
            //messages = new List<Message>();
            //string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            //using (IDbConnection connection = new SqlConnection(connectionString)) {
            //    connection.Open();
            //    IDbCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandText = $"select * from Message";
            //    DbDataReader reader = (DbDataReader)command.ExecuteReader();
            //    if (reader.HasRows) {
            //        while (reader.Read()) {
            //            Message message = new Message {
            //                Content = (string)reader["Content"],
            //                Id = (int)reader["ID"],
            //             //   HasRead = (bool)reader["HasRead"],
            //            };
            //            messages.Add(message);
            //        }
            //    }
            //}

                //new Message() {
                //        Id=1,
                //        Content="欢迎你加入“一起帮”！记得完成“新手任务”获得 帮帮点 奖励哟。O(∩_∩)O~",
                //        CreateTime=DateTime.Now
                //    },}   
        }
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
                            //   HasRead = (bool)reader["HasRead"],
                        };
                        messages.Add(message);
                    }
                }
            }
            //DBHelper helper = new DBHelper();
            //string cmd= $"select * from Message";
            //DbDataReader reader = helper.ExecuteReader(cmd);
            //if (reader.HasRows) {
            //    while (reader.Read()) {
            //        Message message = new Message {
            //            Content = (string)reader["Content"],
            //            Id = (int)reader["ID"],
            //            //   HasRead = (bool)reader["HasRead"],
            //        };
            //        messages.Add(message);
            //    }
            //}

            var result = messages;
            if (onlyNotRead) {
                //  return messages.Where(m => !m.HasRead).ToList();
                result = messages.Where(m => !m.HasRead).ToList();//未读的
            }

            //else {
            //    return messages;
            //}
            //else nothig
            return result;

        }
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
                        }                 
                    }
            return message;
        }
          
            

        

    }
}
