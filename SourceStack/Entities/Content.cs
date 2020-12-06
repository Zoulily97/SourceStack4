using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStack.Entities
{
    public class Content:Entity
    {  
        //kind 作者 标题 关键字 内容 赞 踩    
        public string kind;
        //private DateTime createTime;
        [Required (ErrorMessage ="标题不能为空")]
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Keyword> keywords { get; set; }
        public DateTime PublishTime { get; protected set; }
        public int HelpMoney { get; set; }




        //*1、确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串；
        // 而且如果标题前后有空格，将空格予以删除

        public Content()//createTime赋值
        {
            // createTime = DateTime.Now;
            PublishTime = DateTime.Now;
        }
        public virtual void Publish()
        {
            //内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
            if (Author == null) {
                throw new Exception("参数为空");
            }

        }
        public Content(string kind)
        {
            this.kind = kind;
        }


    }
}
