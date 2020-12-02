using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;

namespace SourceStack.Entities
{
    public class Comment
    {

        //一个评论必须有一个它所评论的文章
        public Article Article { get; set; }
        
        //评价
      //  public IList<Appraise> Appraise { get; set; }
    }
}
