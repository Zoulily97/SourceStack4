using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoeTest
{
    class SqlDbContext: DbContext
    {
        //通过声明Dbset 哪些Enbtity需要是映射
        public DbSet<User> Users { get; set; }
        public DbSet <Message> Messages { get; set; }
        public DbSet <Article > Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet <Email > Emails { get; set; }


       // public DbSet<User1> User1s { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//配置数据库
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=yqbang6;Integrated Security=True;";
            optionsBuilder.UseSqlServer(constr)
                .EnableSensitiveDataLogging()
                .LogTo((id, level) => level == Microsoft.Extensions.Logging.LogLevel.Debug,//过滤
                log => Console.WriteLine(log));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("Register")
                .Property(u => u.Name).HasColumnName("UserName").HasMaxLength(256)
                ;
            modelBuilder.Entity<User>()
                 .Property(u => u.Password).IsRequired();
            modelBuilder.Entity<User>()
                .Ignore(u => u.FailedTry);
            modelBuilder.Entity<User>()
              .HasIndex(u => u.CreateTime)
              .IsUnique();


            //modelBuilder.Entity<User>()
            //    .Ignore(u => u.Id);
            //modelBuilder.Entity<User>()
            //   .HasKey(u => u.Name);
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);


            //modelBuilder.Entity<Article>().HasBaseType((Type)null);//分表 不建议用  取消继承关系
            //modelBuilder.Entity<Comment >().HasBaseType((Type)null);
            //modelBuilder.Entity<Keyword >().HasBaseType((Type)null);
            //modelBuilder.Entity<Message>().HasBaseType((Type)null);

            modelBuilder.Entity<User>()
              .HasOne<Email>(s => s.SendTo)
              .WithOne(b => b.EmailAuthor)
              .HasForeignKey<User>(s => s.SendToId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
