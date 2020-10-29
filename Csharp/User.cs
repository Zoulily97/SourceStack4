using System;

namespace Csharp
{
    //作业：
    //1、将之前User / Problem / HelpMoney类的字段封装成属性，其中：
    //  1、user.Password在类的外部只能改不能读
    //  2、如果user.Name为“admin”，输入时修改为“系统管理员”
    //  3、problem.Reward不能为负数
    //2、调用这些类的有参 / 无参构造函数，生成这些类的对象，调用他们的方法
    //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
    //4、设计一种方式，保证：
    //  1、每一个Problem对象一定有Body赋值
    //  2、每一个User对象一定有Name和Password赋值

    //1、让User类无法被继承
    sealed class User:ISendMessage,IChat
    {

        private string name;
        private string password;
        private User invitesBy;

        public string Password { private get; set; }//  user.Password在类的外部只能改不能读
        public User InvitesBy { get; set; }
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        public string Name
        {
            get => name;
            set
            {
                if (value == "admin")
                {
                    name = "系统管理员 ";
                }
                else
                {
                    name = value;
                }
            }
        }

        public User()
        {

        }
        public User(string name,string password)  //有参构造函数//赋值
        {
            this.name = name;
            this.password = password;
        }

        public static void Register()
        {

        }
        public static void Login()
        {

        }

      
        void ISendMessage.send()
        {
            throw new NotImplementedException();
        }

        public void send()
        {
            throw new NotImplementedException();
        }
    }
}
