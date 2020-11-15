using Csharp.作业;
using Csharp.其他;
using System;
using System.Linq;

namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {



            //C# 单元测试 双向链表
            #region
            /*作业：为之前作业添加单元测试，包括但不限于：
                     数组中找到最大值
                     找到100以内的所有质数
                     猜数字游戏
                     二分查找
                     栈的压入弹出
                     继续完成双向链表的测试和开发，实现：
                     node3.InsertAfter(node1); 场景
                     InerstBefore()：在某个节点前插入
                      Delete()：删除某个节点
                     [选] Swap()：交互某两个节点
                     [选] FindBy()：根据节点值查找到某个节点
            */
            #endregion



            //C#-面向对象：string还是StringBuilder？ https://zhuanlan.zhihu.com/p/93747718
            #region
            /*1、确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串；
                 而且如果标题前后有空格，将空格予以删除
               2、设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。
              3、确保用户（User）的密码（Password）：
                   长度不低于6
                   必须由大小写英语字母、数字和特殊符号（~!@#$%^&*()_+）组成
            4、实现 int GetCount(string container, string target)方法，可以统计出container中有多少个target
            5、不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，
                比如：mimicJoin("-", "a", "b", "c", "d")，其运行结果为：a - b - c - d*/
            //Con("P@ss12345");
            //Console.WriteLine(Work.GetCount("1234445678", "4"));
            //string[] vs = new string[] { "a", "b", "c", "d" };
            //Console.WriteLine(Work.MimicJoin("-", vs));

            #endregion




            //泛型：声明/使用/约束/继承
            #region
            /*作业：
             改造Entity类，让其Id可以为任意类型
             用泛型改造二分查找、堆栈和双向链表
             用泛型改造“取数组中最大值”（提示：IComparable）
             用代码演示泛型接口的协变/逆变*/
            //int[] seek = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            //Console.WriteLine(SomeArray<int>.BinarySeek(seek, 17));
            //MimicStack<object> mimicStack1 = new MimicStack<object>();
            // mimicStack1.Push(1);
            // mimicStack1.Push("1234");
            // mimicStack1.Push("中国");
            // mimicStack1.Push(4);
            // mimicStack1.Push(5);
            // //  mimicStack1.Push(6);//溢出
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            //int[] seek1 = { 1, 11, 13, 15, 17, 193, 5, 7, 10};
            //Console.WriteLine( SomeArray<int>.getMaxArray(seek1));


            #endregion


            // 集合：List / Dictionary ……
            #region
            /*
             * 在现有作业的基础上，观察一起帮的文章板块，以此为蓝本，补充（如果还没有的话）声明：
               评论（Comment）类
               评价（Appraise）类：包括“赞（Agree）”和“踩（Disagree）”
                关键字（Keyword）类
            并构建以下关系：
               一篇文章可以有多个评论
               一个评论必须有一个它所评论的文章
                每个文章和评论都有一个评价
               一篇文章可以有多个关键字，一个关键字可以对应多篇文章

             */
            #endregion




            #region
            /* 作业：
           使用VS git完成：
             1、新建两个分支，如：hotfix和t1
             2、切换到hotfix，在hotfix上进行若干提交
             3、修改hotfix上再上一次的提交后重新提交
             4、讲hotfix上的修改合并到master上
             5、删除hotfix分支
             6、将上述修改全部push到远程仓库，确保远程仓库和本地具有相同的分支
             7、在远程仓库新建一个分支faq
             8、在本地跟踪远程分支faq
             9、在远程和本地faq上交错的提交更改，然后merge
             使用VS和github
             1、将其他某个同学添加成collaborator，让其能够直接push到你的repository
             2、在github上fork一个项目成员的repoistory
             3、克隆到本地，review其代码，进行一处修改（bug fix/ refactor / feature等均可），提交推送
             4、发起 一个 pull request
             5、当其他项目成员发起pull request时，检查并完成其请求*/

            // SomeArray.ArraySort();


            #endregion

            //C#进阶：集合：foreach背后
            #region
            //让之前的双向链表，能够：被foreach迭代
            #endregion

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
               Person.ExecuteWeituo();
            #endregion




        }


     

        
    


        private static void Con(string passeord)
        {


            //var zz = new Regex(@"^(?:(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[~!@#$%^&*()_+])).{6,20}$");
            //if (passeord.Contains(zz.ToString ()))
            //{
            //    Console.WriteLine("ok");
            //}
            //else
            //{
            //    Console.WriteLine("错误");
            //}



            ///666
            string Str = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+";

            if (passeord.Length > 6)
            {
                for (int i = 0; i < passeord.Length; i++)
                {
                    if (!Str.Contains(passeord[i]))
                    {
                        Console.WriteLine("输入有误");
                        break;
                    }

                }
                Console.WriteLine("正确" + passeord);
            }
            else
            {
                Console.WriteLine("输入有误");
            }

        }
        /// <summary>
        /// 构造一个能装任何数据的数组，并完成数据的读写
        /// </summary>
        private static void GetanyArray()
        {
            object[] annyArray = new object[5] { 2.344, 1123, 2345, "中文", true };
            for (int i = 0; i < annyArray.Length; i++)
            {
                Console.WriteLine(annyArray[i]);


            }
        }
        /// <summary>
        /// 遍历100 内所有质数
        /// </summary>
        private static void ZhiNum()
        {
            bool flag;//声明一个bool值用来判断是否是素数
            for (int i = 2; i < 101; i++)// 1、遍历100 内所有数
            {
                //每次循环都把flag的值设置为true,
                flag = true;
                //2、开始第二次循环,让 i 依次除与 2 和小于它的数,当i= 2时(j < i 条件不成立),直接跳出循环输出:素数 2
                for (int j = 2; j < i; j++)
                {
                    //当 i 可以被 j 整除时跳出该循环,该数不是素数,不做输出
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("素数 " + i);
                }
            }
        }




        // 定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
        //最小值min（默认为1）
        //相邻两个元素之间的最大差值gap（默认为5）
        //元素个数length（默认为10个）
        /// <summary>
        /// 生成数组的方法,元素随机生成从小到大排列
        /// </summary>
        private static void GetArray()
        {
            //给随机数组赋值
            int[] arryasc = new int[10];
            Random Rvalue = new Random();
            for (int i = 1; i < 10; i++)
            {
                arryasc[i + 1] = Rvalue.Next(0, 100) + arryasc[i];

                Console.WriteLine(arryasc[i]);
            }
            //冒泡排序
            for (int i = 0; i < arryasc.Length; i++)
            {
                //从小到大 
                for (int j = 0; j < arryasc.Length - 1; j++)
                {
                    if (arryasc[j] > arryasc[j + 1])
                    {
                        int temp = arryasc[j];
                        arryasc[j] = arryasc[j + 1];
                        arryasc[j + 1] = temp;

                    }

                }

            }

        }

        /// <summary>
        /// 通过二分查找法在一个有序数组中找到某个值的下标，找不到返回 - 1
        /// </summary>
        private static void BinarySearch()
        {


        }

        private static void Login()
        {
            Console.WriteLine("请输入验证码");
            if (Console.ReadLine() != "1234")
            {
                Console.WriteLine("*验证码错误");
            }
            else
            {
                Console.WriteLine("请输入用户名");
                if (Console.ReadLine() != "zl")
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    Console.WriteLine("请输入密码");
                    if (Console.ReadLine() != "123456")
                    {
                        Console.WriteLine("用户名或密码错误");

                    }
                    else
                    {
                        Console.WriteLine("恭喜！登录成功！");
                    }
                }
            }
        }

      
    }
}



