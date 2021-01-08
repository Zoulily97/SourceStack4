using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class Repository<T> where T : BaseEntity, new()
    {
        protected SqlDbcontext context;

        protected DbSet<T> dbSet;
        public Repository(SqlDbcontext context)
        {       
            this.context = context;
            dbSet = context.Set<T>();
        }
        public void Save(T entity)
        {
            //context.Entities.Add(entity);
            //context.Set(typeof(T)).Add(entity);
            //context.Set<T>().Add(entity);
            dbSet.Add(entity);
            context.SaveChanges();
            // return entity.Id;

        }
        public T LoadProxy(int id)//只需要拿一个entity的id ,不需要从数据库中取//Load 假装找到
        {
            T entity = new T() { Id = id };
            dbSet.Attach(entity);
            return entity;
        }
    }
}
