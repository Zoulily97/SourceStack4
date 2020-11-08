﻿using Csharp.作业;
using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#-面向对象-万物皆对象：Object和装箱拆箱2020111https://zhuanlan.zhihu.com/p/93458057
            #region
            /*在https://source.dot.net/中找到 Console.WriteLine(new Student()); 输出Student类名的源代码
            思考dynamic和var的区别，并用代码予以演示
            构造一个能装任何数据的数组，并完成数据的读写
            使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素*/
            //Console.WriteLine(new Student());
            //Console.WriteLine(typeof(Student).Name);  //Student //typeof 类型 传类名  编译时类型

            //// var 在编译阶段已经确定类型，在初始化时候，必须提供初始化的值，
            ////而dynamic则可以不提供，它是在运行时才确定类型。
            //dynamic num1;
            //// var num2;// 报错：变量必须赋初值
            //num1 = "99";
            //Console.WriteLine(num1.GetType());//String 
            //                                  // Console.WriteLine(num1 - 98);// 未经处理的异常:   运算符“-”无法应用于“string”和“int”类型的操作数
            //                                  //构造一个能装任何数据的数组，并完成数据的读写
            //GetanyArray();




            #endregion

            //C#-面向对象-反射和特性 2020-11-2 https://zhuanlan.zhihu.com/p/93440022
            #region
            /*之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，想一想他们应该在哪里赋值比较好，并完成相应代码
              在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime
              自定义一个特性HelpMoneyChanged（帮帮币变化）：
              该特性只能用于方法
              有一个构造函数，可以接受一个int类型的参数amount，表示帮帮币变化的数量
              有一个string类型的Message属性，记录帮帮币变化的原因
              将HelpMoneyChanged应用于Publish()方法
              用反射获取Publish()上的特性实例，输出其中包含的信息*/
            Problem problem2 = new Problem();
            Console.WriteLine("特性");
            Attribute attribute = HelpMoneyChangedAttribute.GetCustomAttribute(typeof(Problem)
                .GetMethod("Publish"),
                typeof(HelpMoneyChangedAttribute)
                 );
            //将基类的Attribute对象强转为子类
            Console.WriteLine(((HelpMoneyChangedAttribute)attribute).Amount);



            #endregion
            //C#
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


            Console.WriteLine("hotfix上更改1次");
            Console.WriteLine("hotfix上更改2次");

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




            #endregion

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

        /// <summary>
        ///  //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
        /// </summary>
        public static DateTime GetDate(string dateString, int amount, TimeEnum unit)
        {
            DateTime basetime = DateTime.ParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);

            switch (unit)
            {
                case TimeEnum.day:
                    return basetime.AddDays(amount);
                case TimeEnum.week:
                    return /*Convert.ToDateTime(*/basetime.AddDays(amount * 7);
                case TimeEnum.mouth:
                    return basetime.AddMonths(amount);
                default:
                    break;
            }
            return basetime;
        }
        /// <summary>
        /// 判定是一年的第一周，周一是几号
        /// </summary>
        /// <param name="dateTime">年份</param>   
        public static DateTime GetDate(int year)
        {
            //DateTime year = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(year); 

            //2019
            //2019.1.1 

            DateTime dt = new DateTime(year, 1, 1);
            Console.WriteLine(dt);//20201.1

            while (dt.DayOfWeek != DayOfWeek.Monday)
            {

                dt = dt.AddDays(1);//2020.1.6 周一
            }

            return dt;   //2020/1/6

        }
        /// <summary>
        ///  给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
        /// </summary>
        /// <param name="year"></param>
        public static void GetDateWeek(int year)
        {
            GetWeekBody(GetDate(year));//2020/1/6
        }

        /// <summary>
        /// 按周排列显示每周的起始日期
        /// </summary>
        /// <param name="dateTime"></param>
        public static void GetWeekBody(DateTime dateTime)//2020/1/6
        {
            int i = 1;
            int year = dateTime.Year;
            while (dateTime.Year == year)
            {
                Console.WriteLine($"第{i}周：{dateTime.ToString("yyyy年MM月dd日")}-" +
                    $"{dateTime.AddDays(6).ToString("yyyy年MM月dd日")}");
                dateTime = dateTime.AddDays(7);
                i++;
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

        /// <summary>
        /// 设立并显示一个多维数组的值，元素值等于下标之和。
        /// </summary>
        private static void MarreyXB()
        {
            int[,] Marrey = new int[3, 4];
            // GetLength(0) 获得第一维的长度(行数) GetLength(1) 获得第二维的长度(列数)
            for (int i = 0; i < Marrey.GetLength(0); i++)
            {
                for (int j = 0; j < Marrey.GetLength(1); j++)
                {
                    Console.Write(i + j + "---");
                }
                Console.WriteLine("\n");
            }
        }

        /// <summary>
        ///  利用ref调用Swap()方法交换两个同学的床位号
        /// </summary>
        private static void Swap()
        {

        }

        /// <summary>
        ///   //传入一个数组返回最小值
        /// </summary>
        private static void getMinArray()
        {
            int[] arraymax = { 2, 5, 7, 8, 9 };
            for (int i = 0; i < arraymax.Length; i++)
            {
                //从小到大 
                for (int j = 0; j < arraymax.Length - 1; j++)
                {
                    if (arraymax[j] < arraymax[j + 1])
                    {
                        int temp = arraymax[j];
                        arraymax[j] = arraymax[j + 1];
                        arraymax[j + 1] = temp;

                    }

                }

            }

            Console.WriteLine(arraymax[arraymax.Length - 1]);

        }
        /// <summary>
        ///   //传入一个数组返回最大值
        /// </summary>
        private static void getMaxArray()
        {
            int[] arraymax = { 2, 5, 7, 8, 9 };
            for (int i = 0; i < arraymax.Length; i++)
            {
                //从小到大 
                for (int j = 0; j < arraymax.Length - 1; j++)
                {
                    if (arraymax[j] > arraymax[j + 1])
                    {
                        int temp = arraymax[j];
                        arraymax[j] = arraymax[j + 1];
                        arraymax[j + 1] = temp;

                    }

                }

            }

            Console.WriteLine(arraymax[arraymax.Length - 1]);
        }
        /// <summary>
        ///  生成一个元素（值随机）从小到大排列的数组
        /// </summary>
        public static void ArraySort()
        {
            //给随机数组赋值
            int[] arryasc = new int[10];
            Random Rvalue = new Random();
            arryasc[0] = Rvalue.Next(5);
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
        //传入一个数组返回最大值，最小值

        /// <summary>
        /// 猜数游戏
        /// </summary>
        //完成“猜数字”游戏，方法名GuessMe()：
        //随机生成一个大于0小于1000的整数
        //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        //没猜中可以继续猜，但最多不能超过10次
        //如果5次之内猜中，输出：你真牛逼！
        //如果8次之内猜中，输出：不错嘛！
        //10次还没猜中，输出：(～￣(OO)￣)ブ  
        public static void GuessMe()
        {

            Random r = new Random();
            int b = r.Next(0, 1000);//随机数
            Console.WriteLine(b);
            Console.WriteLine("请输入您猜的数字：");

            ///1、猜中
            ///1.1检查次数
            ///2、未猜中
            ///2.1未到10次，继续
            ///2.2到了10次,结束
            for (int i = 0; i < 20; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a != b)
                {
                    if (i <= 10)
                    {
                        if (a > b)
                        {
                            Console.WriteLine("大了");
                        }
                        else if (a < b)
                        {
                            Console.WriteLine("小了");
                        }
                    }
                    else if (i > 10)
                    {
                        Console.WriteLine("不能再输了");
                        break;
                    }
                }
                else
                {
                    if (i <= 5)
                    {
                        Console.WriteLine("你真牛逼");
                    }
                    else if (i <= 8)
                    {
                        Console.WriteLine("不错嘛！");
                    }
                    else if (i <= 10)
                    {
                        Console.WriteLine("这么多次才中，加油哦");
                    }
                }

            }

        }

        /// <summary>
        /// 平均成绩
        /// </summary>
        /// <param name="score1"></param>
        public static void GetAverage(double[] score1)
        {
            double sum = 0;
            double avg = 0;

            for (int i = 0; i < score1.Length; i++)
            {
                sum += score1[i];
            }
            avg = Math.Round((sum / score1.Length), 2);
            Console.WriteLine("分数是" + avg);



        }
        public static void grow(Student student)//2、18
        {
            // student = new Student();
            student.age++;
            Console.WriteLine(student.age);//3、19

        }
        public static void grow(ref Student student)
        {
            student = new Student();
            student.age++;
            Console.WriteLine(student.age);
        }
    }
}



