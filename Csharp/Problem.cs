using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    
    //作业：
    //观察“一起帮”的：
    //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    //为这些类的字段和方法设置合适的访问修饰符
    public class Problem
    {
        //crtl+r+e
        private string title;
        private string body;
        private int reward;
        private DateTime publishDateTime;
        private string author;
        public string Title { get => title; set => title = value; }   
        public string Body { get => body; set => body = value; }
       
        //  3、problem.Reward不能为负数
        public int  Reward { get => reward; set => reward = value; }   
        public DateTime PublishDateTime { get => publishDateTime; set => publishDateTime = value; }   
        public string Author { get => author; set => author = value; }
        public string[] HelpFiled { get; set; }
        //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        public static void Publish()
        {

        }
      
    }
}
