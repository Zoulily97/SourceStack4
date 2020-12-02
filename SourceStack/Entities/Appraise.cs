using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStack.Entities
{
    public class Appraise
    {

        //每个文章和评论都有一个评价
        public Article Article { get; set; }
        public Comment Comment { get; set; }
    }
}
