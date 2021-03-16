
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BLL.Entities
{
    public class Article: BaseEntity
    {
        
        //kind 作者 标题 关键字 内容 赞 踩    
        public string kind;
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
       public IList<Comment> Comments { get; set; }
        public IList<Keyword> Keywords { get; set; }
        public DateTime PublishTime { get; set; } 
        public string Summary { get; set; }
        


    }
}
