﻿namespace Csharp
{
    //C#-面向对象：基础中的基础-类和对象 20201019 https://zhuanlan.zhihu.com/p/92362781

    //作业：
    //观察“一起帮”的：
    //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    //为这些类的字段和方法设置合适的访问修饰符




    sealed class User
    {

        private string name;
        private string password;
        private User invitesBy;

        public string Password { private get; set; }//  1、user.Password在类的外部只能改不能读
        public User InvitesBy { get; set; }
        public static void Register()
        {

        }
        public static void Login()
        {

        }
    }
}
