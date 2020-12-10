using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ADO
{
    class Program
    {
        public static SqlConnection DbConnection { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string name = Console.ReadLine();
           // string password = Console.ReadLine();


            //1、链接数据库
            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            // IDbConnection connection = new SqlConnection(connectionString);
            //  打开数据库
            // using 释放资源
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        IDbCommand command = new SqlCommand();
                        command.Transaction = transaction;//仍然需要指定链接 //能够正常执行
                        command.CommandText = "UPDATE Student SET Age -= 1;";
                        command.ExecuteNonQuery();

                        //会违反Age>0的约束
                        command.CommandText = "UPDATE Student SET Age -= 108;";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        //注意不能对异常“不予处理”，直接吞了
                        throw;
                    }
                }


















                //2、数据库命令
               // IDbCommand command = new SqlCommand();
                //Command对象中必须要有依赖两个属性：属性给他赋值
              //  command.Connection = connection;
              //  command.CommandType = CommandType.StoredProcedure;
                //  command.CommandText = "insert  Student values(5,N'廖',N'005',N'20');";
                //3、执行
                //int rows = command.ExecuteNonQuery();

                //command.CommandText = "select count(*) from Student";
                // command.CommandText="select [Name] from Student where Id=5";

                //object count= command.ExecuteScalar();

                //command.CommandText = "select * from Student";
                //IDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    for (int i = 0; i < reader.FieldCount; i++)
                //    {
                //        Console.Write(reader[i]+"");
                //    }
                //    Console.WriteLine();
                //}


                //模拟登录
                // command.CommandText = $"select [stuNumber] from Student " + $"where [Name]=N'{name}'";
                //command.CommandText = $"select [stuNumber] from Student " + $"where [Name]=@name";
                //IDataParameter pName = new SqlParameter("@Name",name);//防Sql注入，参数化查询
                //command.Parameters.Add(pName);
                //string onumber= command.ExecuteScalar()?.ToString();
                //if (onumber==null)
                //{
                //    Console.WriteLine("用户名不存在");
                //    return;
                //}
                //if (onumber!=password)
                //{
                //    Console.WriteLine("密码错误");
                //    return;
                //}


              //  command.CommandText = "insert  Student([Name]) values(N'廖er');" +
              //                       "select @@identity";
              ////  command.ExecuteScalar();
              //  Console.WriteLine(command.ExecuteScalar());
            }
            //

            //try
            //{
            //    connection.Open();

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    connection.Close();
            //    connection.Dispose();
            //    connection = null;

            //}
        }
    }
}
