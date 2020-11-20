using System;

namespace Csharp
{
    //添加一个新类ContentService，其中有一个发布（Publish()）方法：
    //如果发布Article，需要消耗一个帮帮币
    //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
    //如果发布Suggest，不需要消耗帮帮币
    //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine()代替。根据我们学习的继承和多态知识，实现上述功能。

    /* 3、在ContentService中捕获异常
                 如果是“参数为空”异常，Console.WriteLine() 输出：内容的作者不能为空，将当前异常封装进新异常的InnerException，再将新异常抛出
                 如果是“”参数越界”异常，Console.WriteLine() 输出：求助的Reward为负数（-XX），不再抛出异常
             4、ContentService中无论是否捕获异常，均要Console.WriteLine() 输出：XXXX年XX月XX日 XX点XX分XX秒（当前时间），请求发布内容（Id = XXX）
              在Main()函数调用ContentService时，捕获一切异常，并记录异常的消息和堆栈信息*/
    public class ContentService : Content//内容服务
    {
        public void Publish()
        {




        }
        public void Publish(Content content)
        {
            try
            {
                content.Publish();
                // Console.WriteLine("存到数据库");
            }
            catch (Exception)
            {

                throw new Exception("异常");
            }
            finally
            {
                Console.WriteLine(System.DateTime.Now);
            }


        }
    }
}
