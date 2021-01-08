using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
   public  class UserRepository : Repository<User>
    {
        public UserRepository(SqlDbcontext context) : base(context)
        {

        }
        public User GetByName(string name)
        {
            return dbSet.Where(s => s.Name == name).SingleOrDefault();

        }

        
    }
}
