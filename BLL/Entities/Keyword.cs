using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Keyword : BaseEntity
    {
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public IList<Article> Articles { get; set; }
        public string Name { get; set; }
    }
}
