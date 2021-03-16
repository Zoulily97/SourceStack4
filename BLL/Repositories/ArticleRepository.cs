using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ArticleRepository : Repository<Article>
    {
        public ArticleRepository(SqlDbcontext context) : base(context)
        {

        }

        //根据文章id 获取整个文章
        public Article GetById(int id)
        {
            return dbSet.Where(s => s.Id == id).SingleOrDefault();
        }
        
    }
}

