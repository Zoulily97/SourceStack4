using System;
using System.Collections.Generic;

namespace EFCoeTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            SqlDbContext context = new SqlDbContext();
            var db = context.Database;
            //类似于Update - Database: apply all pending migrations
            //本身不生成Migrations
            //    db.Migrate();
            db.EnsureDeleted();
            db.EnsureCreated();


            //User user1 = new User()
            //{
            //    Name = "lw",
            //    Password = "1234",
            //    Id = 1,
            //    HelpMoney = 100,
            //    CreateTime = DateTime.Now
            //};
            //context.Add<User>(user1);
            //List<User> users = new List<User>()
            //{
            //   new User()
            //    {
            //        Name = "gty",
            //        Password = "1234",
            //        Id = 2,
            //        HelpMoney=100,
            //        CreateTime=DateTime.Now
            //    },
            //    new User()
            //    {
            //        Name = "zl",
            //        Password = "1234",
            //        Id = 3,
            //        CreateTime=DateTime.Now,
            //        HelpMoney=100
            //    },
            //     new User()
            //    {
            //        Name = "lzb",
            //        Password = "1234",
            //        Id = 4,
            //        CreateTime=DateTime.Now,
            //        HelpMoney=100
            //    },
            //};
            //context.AddRange(users);


         //   User u1 = context.Find<User>(1);
            //   u1.Name = "刘伟";
            // context.Update<User>(u1);
         //   context.Remove(u1);
            context.SaveChanges();





        }
    }
}
