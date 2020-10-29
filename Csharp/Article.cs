using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{

    //3、实例化文章和意见建议，调用他们：
    // 1、继承自父类的属性和方法
    // 2、自己的属性和方法
    class Article : Content
    {
        //标题,内容，关键字，评论，作者，赞，踩
        private string[] comments;
        public string[] Comments { get => comments; set => comments = value; }

        public override void Agree()
        {
            throw new NotImplementedException();
        }

        public override void Disagree()
        {
            throw new NotImplementedException();
        }

        public override void ReleseHelpMoney()
        {
            Console.WriteLine("需要消耗一个帮帮币");
        }
        public void Search( string keword)
        {

        }



    }
}
