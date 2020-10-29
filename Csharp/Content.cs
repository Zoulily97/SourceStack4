using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    // Article  //标题,内容，关键字，评论，作者，赞，踩
    //Problem   //标题 内容 作者 关键字
    //Suggest //标题,内容，作者，评论，赞，踩
    //2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
    //  1、Content中有一个字段：kind，记录内容的种类（problem / article / suggest等），只能被子类使用
    // 2、确保每个Content对象都有kind的非空值
    // 3、Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
    // 4、其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
    //思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。 抽象类
    //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/ 踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
    //引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），用Console.WriteLine()实现Send()。
    //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。假设User类同时继承了ISendMessage和IChat，如何处理？
    public abstract class Content//抽象类。里面还包括字段，属性，实现方法，抽象方法
    {
        //kind 作者 标题 关键字 内容 赞 踩     
        public  string kind;
        private DateTime createTime;
        private User author;
        private string title;
        //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        private string[] keyword = new string[10];
        public string this[int index]
        {
            get { return keyword[index]; }
            set { keyword[index] = value; }
        }
        public DateTime PulishTime
        {
            get { return createTime; } 
         }
        internal User Author { get ; set  ; }
        public string Title { get => title; set => title = value; }

        public Content()//createTime赋值
        {
            createTime = DateTime.Now;
        }
        public abstract void Agree();//赞

        public abstract void Disagree();//踩
       
       public virtual void ReleseHelpMoney()
        {

        }
        public Content(string kind)
        {
            this.kind = kind;
        }


    }
}
