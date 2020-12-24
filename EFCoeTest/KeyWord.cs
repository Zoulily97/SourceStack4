using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EFCoeTest
{
    public class Keyword:Entity
    {
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public IList<Article> Articles { get; set; }
        public string Name { get;  set; }
    }
}
