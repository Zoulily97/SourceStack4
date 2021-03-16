using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;

namespace BLL.Repositories
{
  public class SqlDbcontext: DbContext
    {
        public SqlDbcontext() : base("20bang")
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
          //  modelBuilder.Entity<Article>();//建表
            base.OnModelCreating(modelBuilder);

        }
    }
}
