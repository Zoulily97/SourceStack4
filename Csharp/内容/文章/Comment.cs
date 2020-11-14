using System.Collections.Generic;

namespace Csharp.文章
{
    public class Comment
    {
        //一个评论必须有一个它所评论的文章
        public Article Article { get; set; }
        public IList<Appraise> Appraise { get; set; }
    }
}
