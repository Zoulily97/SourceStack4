using System.Collections.Generic;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class UserRepository
    {
        public static IList<User> users;
        static UserRepository()
        {
            
        }    
        public User Find(int id)
        {
            return users.Where(a => a.Id == id).SingleOrDefault();   
        }

        //获取登录用户信息
        internal User GetByName(string name)
        {
            User user = new User();

            //DBHelper helper = new DBHelper();

            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            using (IDbConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select * from User1 where name=@name";
                IDataParameter pname = new SqlParameter("@name", name);
                command.Parameters.Add(pname);
                IDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    user.Name =(string) reader["Name"];
                    user.Id = (int)reader["Id"];
                    user.Password = (string)reader["Password"];
                    user.InviterNumber = (string)reader["InviterNumber"];
                }
            }
            return user;

        }
    
        //注册保存用户信息
        public void  Save(User user)
        {

            ////string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            ////using (IDbConnection connection = new SqlConnection(connectionString)) {
            ////    connection.Open();
            ////    IDbCommand command = new SqlCommand();
            ////    command.Connection = connection;
            ////    command.CommandText =
            ////        $"INSERT INTO user1 (name,password,inviterName,inviterNumber) " +
            ////        $"VALUES ('{user.Name}','{user.Password}','{user.Inviter.Name}','{user.Inviter.InviterNumber}');";
            ////    command.ExecuteNonQuery();
            ////}



            DBHelper helper = new DBHelper();
            string cmd = $"INSERT INTO user1 (name,password,inviterName,inviterNumber) " +
                $"VALUES ('{user.Name}','{user.Password}','{user.Inviter.Name}','{user.Inviter.InviterNumber}');";
            helper.Insert(cmd);


            //DBHelper helper = new DBHelper();
            //IDataParameter pname = new SqlParameter("@name", user.Name);
            //IDataParameter ppassword = new SqlParameter("@password", user.Password);
            //IDataParameter pinviterName = new SqlParameter("@inviterName", user.Inviter.Name);
            //IDataParameter pinviterNumber = new SqlParameter("@inviterNumber", user.Inviter.InviterNumber);
            //IDataParameter[] parameters = { pname, ppassword, pinviterName, pinviterNumber };
            //string cmd = $"INSERT INTO user1 (name,password,inviterName,inviterNumber ) VALUES ('@name','@password','@inviterName','@inviterNumber');";
            //helper.Insert(cmd, parameters);
        }


    }
}




