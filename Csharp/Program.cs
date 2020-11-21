using Csharp.其他;
using Csharp.文章;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;

namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {



            //用代码演示泛型接口的协变/逆变*/

            //扩展（extension）方法
            #region
            //调用扩展方法Max()：能够返回之前双向链表中存贮着最大值的节点
            #endregion

            // C#进阶 ： 委托和事件 匿名方法 / Lambda / 闭包
            #region
            /*
             声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
                使用：
                  方法
                  匿名方法
                  lambda表达式
                  给上述委托赋值，并运行该委托
                  声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出*/
            //Person.ExecuteWeituo();
            #endregion

            // C#进阶 Linq-1：where/order/group/select
            #region
            /*作业：
             在之前“文章/评价/评论/用户/关键字”对象模型的基础上，添加相应的数据，然后完成以下操作：

             找出“飞哥”发布的文章

             找出2019年1月1日以后“小鱼”发布的文章
            \
             按发布时间升序/降序排列显示文章

             统计每个用户各发布了多少篇文章

             找出包含关键字“C#”或“.NET”的文章

             找出评论数量最多的文章

             找出每个作者评论数最多的文章*/

           /* //作者
            User fg = new User { Name = "飞哥", Id = 1, };
            User xuaoyu = new User { Name = "小鱼", Id = 2 };
            IEnumerable<User> teachers = new List<User> { fg, xuaoyu };

            //关键字
            Keyword k1 = new Keyword { Word = "C#" };
            Keyword k2 = new Keyword { Word = ".NET" };
            Keyword k3 = new Keyword { Word = "PS" };
            Keyword k4 = new Keyword { Word = "C#" };
            Keyword k5 = new Keyword { Word = "JAVA" };
            IEnumerable<Keyword> keywords = new List<Keyword>
             {
                 k1,k2,k3,k4,k5
             };
            // //文章
            Article articleCsharp = new Article() { Title = "C#学习", Author = fg, Keyword = new List<Keyword>() { k1, k2 } };
            Article articleCsharp2 = new Article() { Title = "C#学习从入门到放弃", Author = fg, Keyword = new List<Keyword>() { k1, k2, k3 } };
            Article articlejava = new Article() { Title = "JAVA学习", Author = fg, Keyword = new List<Keyword>() { k4, k5, k3 } };
            Article articleui = new Article() { Title = "UI学习", Author = xuaoyu, Keyword = new List<Keyword>() { k5, k4, k3 } };
            Article articleps = new Article() { Title = "PS学习", Author = xuaoyu, Keyword = new List<Keyword>() { k5, k4, k3 } };
            Article articleai = new Article() { Title = "测试学习", Author = xuaoyu, Keyword = new List<Keyword>() { k5, k4, k3 } };
            IEnumerable<Article> articles = new List<Article> { articleCsharp, articleCsharp2, articlejava, articleui, articleps, articleai };

            ContentService fb = new ContentService();//ContentService，其中有一个发布（Publish()）方法：
            fb.Publish(articleCsharp);
            fb.Publish(articleui);
            fb.Publish(articleps);
            fb.Publish(articleai);
            articleui.UpdatePublishTime(articleui, new DateTime(2018, 9, 9));//修改articleui发布时间  
            articleps.UpdatePublishTime(articleps, new DateTime(2019, 9, 19));
            articleai.UpdatePublishTime(articleai, new DateTime(2019, 9, 29));

            //评论
            Comment comment1 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
            Comment comment2 = new Comment { Article = articleui, Title = "小鱼老师说的好" };
            Comment comment3 = new Comment { Article = articleui, Title = "小鱼老师说的特好" };
            Comment comment4 = new Comment { Article = articleui, Title = "小鱼老师说的特别好" };
            Comment comment5 = new Comment { Article = articleui, Title = "小鱼老师说的特别别好" };
            Comment comment6 = new Comment { Article = articleCsharp2, Title = "飞哥说得好" };
            Comment comment7 = new Comment { Article = articlejava, Title = "飞哥articlejava说得好" };
            Comment comment8 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
            Comment comment9 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
            Comment comment10 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
            Comment comment11 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
            Comment comment12 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
            Comment comment13 = new Comment { Article = articleCsharp2, Title = "飞哥说得好" };
            IEnumerable<Comment> comments = new List<Comment> { comment1, comment2, comment3, comment4, comment5, comment6, comment7, comment8, comment9, comment10, comment11, comment12, comment13 };

            //找出“飞哥”发布的文章
            //var result = from a in articles
            //             where a.Author.Name == "飞哥"
            //             select a;
            var result = articles.Where(s => s.Author.Name == "飞哥");
            foreach (var item in result)
            {
                Console.WriteLine("飞哥发布的文章" + item.Title);
            }

            //找出2019年1月1日以后“小鱼”发布的文章
            // articleCsharp

            //var result1 = from a in articles
            //              where a.Author == xuaoyu && a.PublishTime > new DateTime(2019, 1, 1)
            //              select a;
            var result1 = articles.Where(a => a.Author == xuaoyu).Where(a => a.PublishTime > new DateTime(2019, 1, 1));
            foreach (var item in result1)
            {
                Console.WriteLine($"2019年1月1日以后“小鱼”发布文章：《《{ item.Title}》》");//ps 测试

            }
            // 按发布时间升序 / 降序排列显示文章
            //var result2 = from a in articles
            //              orderby a.PublishTime descending
            //              select a;
            var result2 = articles.OrderByDescending(a => a.PublishTime);
            foreach (var item in result2)
            {
                Console.WriteLine($"文章{item.Title}发布时间 {item.PublishTime}");
            }

            //统计每个用户各发布了多少篇文章

            //var result3 = from a in articles
            //              group a by a.Author
            //            //接下来对分组结果集再运算（统计）
            //            into ga  //into类似于命名，将之前的结果集命名为：gm
            //              select new  //利用投影
            //              {
            //                  AuthorName = ga.Key.Name,
            //                  num=ga.Count()

            //              };
            var result3 = articles.GroupBy(a => a.Author).Select(ga => new
            {
                AuthorName = ga.Key.Name,
                num = ga.Count()
            });
            foreach (var item in result3)
            {
                Console.WriteLine($"作者名：{item.AuthorName},有{item.num}文章");

            }

            //找出包含关键字“C#”或“.NET”的文章
            //var result4 = from a in articles
            //              where a.Title.Contains("C#") || a.Title.Contains(".NET")
            //              select a;
            //foreach (var item in result4)
            //{
            //    Console.WriteLine($"关键字包含C#,.NET的文章是<<{item.Title}>>");
            //}

            //var result41 = from a in articles
            //               where a.Keyword.Any(k => k.Word == "C#") || a.Keyword.Any(k => k.Word == ".NET")
            //               select a;
            var result41 = articles.Where(a => a.Keyword.Any(k => k.Word == "C#") || a.Keyword.Any(k => k.Word == ".NET"));
            foreach (var item in result41)
            {
                Console.WriteLine($"关键字包含C#,.NET的文章是{item.Title}");
            }




            //找出评论数量最多的文章
            var result5 = from c in comments
                          group c by c.Article//分组依据
                          into gc
                          select new
                          {
                              title = gc.Key.Title,
                              commentnum = gc.Count()
                          };

            foreach (var item in result5)
            {
                if (item.commentnum == result5.Max(g => g.commentnum))
                {
                    Console.WriteLine($"数量最多的文章<{item.title}>的评论有{item.commentnum}篇");
                }
            }

            //找出每个作者评论数最多的文章


            //var result7 = from a in articles
            //              group a by a.Author into ga
            //              select ga.OrderByDescending(ga => ga?.Comments?.Count()).First();

            var result7 = from c in comments
                          join a in articles
                          on c.Article equals a
                          group c by c.Article
                          into gc
                          select new
                          {
                              articl = gc.Key.Title,
                              cnum = gc.Count(),
                              author = gc.Key.Author

                          };
            foreach (var item in result7)
            {
                //if (item.cnum == result7.Max(g => g.cnum))
                //{
                Console.WriteLine($"评论作者{item.author.Name}---评论数多的文章是---{item.articl}----评论数量是{item.cnum}");
                //}
            }
            var result8 = from i in result7
                          group i by i.author;
            // var result8 = result7.GroupBy(i => i.author);


            foreach (var item in result8)
            {
                var kkk = from i in item
                          orderby i.cnum descending
                          select i;
                // var kkk = item.OrderByDescending(i => i.cnum);
                Console.WriteLine($"{kkk.First().author.Name}的{kkk.First().articl}文章第一是{kkk.First().cnum}");
            }






            */
            #endregion



            //将之前作业的Linq查询表达式用Linq方法实现
            #region
            /*作业：
               将之前作业的Linq查询表达式用Linq方法实现
               找出每个作者最近发布的一篇文章
               为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的求助作者*/


            //var result7 = from a in articles
            //              group a by a.Author into ga
            //              select ga.OrderByDescending(ga => ga?.Comments?.Count()).First();
            //var re = from a in articles group a by a.Author into ga select ga.OrderByDescending(ga => ga.PublishTime).First();
            //foreach (var item in re)
            //{
            //    Console.WriteLine(item.Title + item.PublishTime + item.Author.Name);
            //}
            User problemer1 = new User() { HelpMoney = 15, Name = "小张" };//9
            User problemer2 = new User() { HelpMoney = 15, Name = "小名" };//12
            User problemer3 = new User() { HelpMoney = 5, Name = "小李" };//2
            User problemer4 = new User() { HelpMoney = 5, Name = "小鑫" };//5
            IEnumerable<User> problemers = new List<User> { problemer1, problemer2, problemer3, problemer4 };
            Problem p1 = new Problem(3) { Author = problemer1 };
            Problem p2 = new Problem(3) { Author = problemer1 };
            Problem p3 = new Problem(3) { Author = problemer2 };
            Problem p4 = new Problem(1) { Author = problemer3 };

            ContentService fb1 = new ContentService();
            fb1.Publish(p1);
            fb1.Publish(p2);
            fb1.Publish(p3);
            fb1.Publish(p4);
            //p1.Publish();
            //p2.Publish();
            //p3.Publish();
            //p4.Publish();
            var rs = problemers.Where(a => a.HelpMoney > 5);
            foreach (var item in rs)
            {
                Console.WriteLine(item.Name);//小张,小名
            }

            #endregion

            //C#进阶：异常处理
            #region
            /*作业：
             1、修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常
             2、内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
              3、在ContentService中捕获异常
                 如果是“参数为空”异常，Console.WriteLine()输出：内容的作者不能为空，将当前异常封装进新异常的InnerException，再将新异常抛出
                 如果是“”参数越界”异常，Console.WriteLine()输出：求助的Reward为负数（-XX），不再抛出异常
             4、ContentService中无论是否捕获异常，均要Console.WriteLine()输出：XXXX年XX月XX日 XX点XX分XX秒（当前时间），请求发布内容（Id = XXX）
              在Main()函数调用ContentService时，捕获一切异常，并记录异常的消息和堆栈信息*/

            //  Problem p41 = new Problem(1) { Author = problemer3 };
            // Problem p5 = new Problem(1);
            //fb1.Publish(p5);
            ////  p41.Publish();
            //  ContentService fb1 = new ContentService();
            //  fb1.Publish(p41);
            // p5.Publish();



            #endregion

            // C#进阶：IO和文件操作
            #region
            //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
            //随机字符串
            //混淆用的各色像素点
            //混淆用的直线（或曲线）
            #endregion


        }

















    }
}



