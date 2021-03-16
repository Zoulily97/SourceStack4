using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class KeywordRepository : Repository<Keyword>
    {
        public KeywordRepository(SqlDbcontext context) : base(context)
        {

        }

        //public void Save(IList<Keyword> keywords)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
