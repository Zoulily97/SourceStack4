using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#:面向过程：变量和类型
            #region
            //作业：
            //观察一起帮个人资料页面，用合适的变量类型存储页面用户输入信息，并解释为什么。
            #endregion

            //C#:面向过程：运算符和表达式
            //作业
            #region
            //1、输出两个整数 / 小数的和 / 差 / 积 / 商
            //2、电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
            //3、想一想以下语句输出的结果：
            //4、想一想如下代码的结果是什么，并说明原因：
            //5、当a为何值时，结果为true？
            //--1
            //int a = 6;
            //int b = 3;
            //Console.WriteLine("输出两个整数的和/差/积/商");
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //float c = 5.3F;
            //float d = 3.2F;
            //Console.WriteLine("输出两个小数的和/差/积/商");
            //Console.WriteLine(c + d);
            //Console.WriteLine(c - d);
            //Console.WriteLine(c * d);
            //Console.WriteLine(c / d);

            ////--2
            //Console.WriteLine("---电脑计算并输出：[(23+7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）---");
            //int e = 23, f = 7, g = 12, h = 8, m = 6;
            //decimal result = (decimal)((e + f) * g - h) / m;
            //Console.WriteLine(decimal.Round(result, 2));

            ////--3
            //Console.WriteLine("想一想以下语句输出的结果：");
            //int i = 15;
            //Console.WriteLine(i++);//15
            //i -= 5;    // i=16
            //Console.WriteLine(i);//11
            //Console.WriteLine(i >= 10);//true
            //Console.WriteLine("i值的最终结果为：" + i);

            ////--4
            //int j = 20;
            //Console.WriteLine($"{i}+{j}={i + j}");
            //Console.WriteLine("想一想如下代码的结果是什么，并说明原因");
            //int k = 10;
            //Console.WriteLine(k > 9 && (!(k < 11) || k > 10));//false
            //Console.WriteLine("--1  且---0-|--1-------或---0-----");
            //int a1 = 10;

            ////--5
            ////当a为何值时，结果为true？
            //bool result1 = (a1 + 3 > 12) && a1 < 3.14 * 4 && a1 != 11;
            //Console.WriteLine(result1);
            //Console.ReadKey();
            #endregion
            //C#:面向过程：分支：if...else
            //作业
            #region
            // 观察一起帮登录页面，用if...else ...完成以下功能。
            //用户依次由控制台输入：验证码、用户名和密码：
            //如果验证码输入错误，直接输出：“*验证码错误”；
            //如果用户名不存在，直接输出：“*用户名不存在”；
            //如果用户名或密码错误，输出：“*用户名或密码错误”
            //以上全部正确无误，输出：“恭喜！登录成功！”
            //PS：验证码 / 用户名 / 密码直接预设在源代码中，输入由Console.ReadLine()完成。
            //Login();
            #endregion
            //C#:面向过程：数组  http://17bang.ren/Article/294
            ////作业：
            #region
            ////将源栈同学姓名 / 昵称分别：
            ////按进栈时间装入一维数组，
            ////按座位装入二维数组，
            ////并输出共有多少名同学。
            //string[] studentname = { "刘伟", "李智博", "龚廷义", "廖光银", "周丁浩", "邹丽", "胡涛" };
            //int k;
            //for (k = 0; k < studentname.Length; k++)
            //{
            //}
            //Console.WriteLine("共有" + k + "名同学");

            //string[,] location = new string[3, 4];
            //location[0, 1]= "刘伟";
            //location[0, 3] = "龚廷义";
            //location[1, 0] = "李智博";
            //location[1, 1] = "周丁浩";
            //location[1, 2] = "廖光银";
            //location[2, 1] = "邹丽";
            //location[2, 3] = "胡涛";
            ////int i;
            ////int j;
            ////for (i = 0; i <3; i++)
            ////{
            ////    for (j = 0; j < 4; j++)
            ////    {
            ////        Console.WriteLine(/*"location[{0},{1}] = {2}", i, j, */location[i, j]);
            ////    }

            ////}

            #endregion

            //C#:面向过程：循环 http://17bang.ren/Article/438
            #region
            //作业：
            //1、分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //2、用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //3、让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //4、将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //5、找到100以内的所有质数（只能被1和它自己整除的数）
            //6、生成一个元素（值随机）从小到大排列的数组

            ////---1
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i < 10; i += 2) ///这种方法也可以
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}
            //int i = 1;
            //while (i < 6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //int i = 1;
            //while (i < 10)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            //--2
            ////用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //string[] studentname = { "刘伟", "李智博", "龚廷义", "廖光银", "周丁浩", "邹丽", "胡涛" };
            //for (int i = 0; i < studentname.Length - 1; i++)
            //{
            //    Console.WriteLine(studentname[i]);

            //}
            //string[,] location = new string[3, 4];
            //location[0, 1] = "刘伟";
            //location[0, 3] = "龚廷义";
            //location[1, 0] = "李智博";
            //location[1, 1] = "周丁浩";
            //location[1, 2] = "廖光银";
            //location[2, 1] = "邹丽";
            //location[2, 3] = "胡涛";
            //int i;
            //int j;
            ////bool result = false;
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 4; j++)
            //    {

            //            Console.WriteLine("location[{0},{1}] = {2}", i, j, location[i, j]);


            //    }

            //}
            //-- 3、让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 99; i >= 0; i--)
            //{
            //    sum += i;
            //    i--;
            //}
            //Console.WriteLine(sum);//2500
            //--4 将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] score = { 98, 89, 78, 64, 88, 72 };
            //double Smax = score[0];
            //for (int i = 0; i < score.Length; i++)
            //{
            //    if (Smax > score[i])
            //    {

            //    }

            //}
            //--5找到100以内的所有质数（只能被1和它自己整除的数）
            //定义：素数只能被1和它自身整除的数,1不是素数 (2是最小的素数)
            //思路： 求某个数N是不是素数？用for循环让N依次除以 从2~(N - 1)之间的数，
            // 如果能被整除，则N不是素数，反之则是。
            // 12345678910
            //bool flag;//声明一个bool值用来判断是否是素数
            //for (int i = 2; i < 101; i++)// 1、遍历100 内所有数
            //{
            //    //每次循环都把flag的值设置为true,
            //    flag = true;
            //    //2、开始第二次循环,让 i 依次除与 2 和小于它的数,当i= 2时(j < i 条件不成立),直接跳出循环输出:素数 2
            //    for (int j = 2; j < i; j++)
            //    {
            //        //当 i 可以被 j 整除时跳出该循环,该数不是素数,不做输出
            //        if (i % j == 0)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }
            //    if (flag)
            //    {
            //        Console.WriteLine("素数 " + i);
            //    }
            //}
            //6、生成一个元素（值随机）从小到大排列的数组
            //ArraySort();
            //7-设立并显示一个多维数组的值，元素值等于下标之和。
            //MarreyXB();
            #endregion
            // C#:面向过程：方法基础：声明/调用/返回值 http://17bang.ren/Article/299
            #region
            //作业
            //将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。
            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //完成“猜数字”游戏，方法名GuessMe()：
            //随机生成一个大于0小于1000的整数
            //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
            //没猜中可以继续猜，但最多不能超过10次
            //如果5次之内猜中，输出：你真牛逼！
            //如果8次之内猜中，输出：不错嘛！
            //10次还没猜中，输出：(～￣(OO)￣)ブ
            //传入一个数组返回最大值，最小值

            //double[] score1 = { 98, 89, 78, 64, 88, 72.8 };
            //GetAverage(score1);//81.5;平均成绩
            //Console.WriteLine("***********************************************");
            //Console.WriteLine("------------欢迎进入猜数字游戏！-------------");
            //Console.WriteLine("我们将从1到1000间随机生成一个数字由玩家进行猜测！");
            //  GuessMe();//猜数字
            //getMaxArray();//9
            //getMinArray();//2

            #endregion
            //C#:面向过程：方法进阶：值/引用传递  20201016  http://17bang.ren/Article/303
            #region
            //作业
            //利用ref调用Swap()方法交换两个同学的床位号
            //  Swap();
            //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            //true / false，表示登陆是否成功
            //string，表示登陆失败的原因
            #endregion

            //C#:面向过程：方法进阶：参数：重载/可选/params 20201016 http://17bang.ren/Article/641
            #region
            //作业
            //定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
            //最小值min（默认为1）
            //相邻两个元素之间的最大差值gap（默认为5）
            //元素个数length（默认为10个）
            //实现二分查找，方法名BinarySeek(int[] numbers, int target)：
            //传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
            //   如果找到，返回该元素所在的下标；否则，返回 - 1

            // GetArray();

            #endregion

            //C#:面向过程：元组 http://17bang.ren/Article/638
            #region
            // 作业
            //使用tuple作为参数，重构SelfIntroduction()方法，输出自我介绍
            //实现方法：
            //IndexOf()，通过遍历在无序数组中
            //--BinarySearch()，通过二分查找法在一个有序数组中
            //--找到某个值的下标，找不到返回 - 1
            //  BinarySearch();
            #endregion

            //C#-面向对象：基础中的基础-类和对象 20201019 https://zhuanlan.zhihu.com/p/92362781
            #region
            //作业：
            //观察“一起帮”的：
            //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
            //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
            //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
            //为这些类的字段和方法设置合适的访问修饰符
            #endregion

            //C#:面向对象：引用类型和值类型  http://17bang.ren/Article/304
            #region
            //作业：
            //在Beauty中：
            //设置一个字段 age，外部只能访问，不能修改
            //设置一个字段 height，添加一个方法GetHeight，让外部能够得到该字段的值，但无法修改
            // 设置一个属性 Weight，外部可以访问和修改，但当外部将Weight值改为负数时，Beauty自行将其归零
            //用最简洁的方式，让Beauty在实例化后，其属性FaceScore立即等于70    
            //作业讲解：
            // 方法和函数
            // property直接复制
            #endregion

            //C#:面向对象：必会面试题目：引用类型和值类型 20201020 https://zhuanlan.zhihu.com/p/92207957
            #region
            //面向对象：引用类型和值类型 https://zhuanlan.zhihu.com/p/92207957
            //作业：
            //用代码和调试过程演示：
            //值类型参数的值传递
            //引用类型参数的值传递
            //值类型参数的引用传递
            //引用类型参数的引用传递
            //return代替引用类型的引用传递
            //思考：为什么需要区分引用类型和值类型？

            ////--1值类型参数的值传递
            //Console.WriteLine("值类型参数的值传递");
            //int i = 18;
            //int j = i;
            //Console.WriteLine(j);//18
            //j = 19;
            //Console.WriteLine(j);//19
            ////--2引用类型参数的值传递
            ////引用类型的值传递。这里是将变量zl的值 复制一份，将副本传递给grow()方法。
            ////变量zl的值，它具体指的是什么？是 new Student()这个对象的地址
            ////因为传递给grow()方法的是对象地址，所以在方法中修改的也就是对象内容，
            ////而最后的输出的也是对象的内容（zl.age），所以……
            //Console.WriteLine("引用类型参数的值传递");
            //Student zl = new Student();
            //zl.age = 18;
            //grow(zl);//1、18
            //Console.WriteLine(zl.age);//4、19
            //                          //--3值类型参数的引用传递
            //Console.WriteLine("值类型参数的引用传递");
            //Student lw = new Student();
            //lw.age = 18;
            //Student clone = lw; //这里是把wx的什么赋值给了clone？
            //clone.age = 20;
            //Console.WriteLine(lw.age);//20
            ////因为 Student clone = lw; 这一行代码，实际上是把变量lw中存放的Student对象地址赋值给了clone，
            ////--4引用类型参数的引用传递
            //Console.WriteLine("引用类型参数的引用传递");
            //Student zll = new Student();
            //zll.age = 18;
            //grow(ref zll);
            //Console.WriteLine(zll.age);
            //Console.WriteLine("hello");
            #endregion

            //C#-面向对象：进一步封装 20201023 https://zhuanlan.zhihu.com/p/92470130
            #region
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
            User ywq = new User("fege", "123");
            Problem problem1 = new Problem("body问题");
            #endregion

            //C#-面向对象：静态还是实例？20201025 https://zhuanlan.zhihu.com/p/95261748
            #region
            //作业：
            //定义一个仓库（Repoistory）类，用于存取对象，其中包含：
            //一个int类型的常量version
            //一个静态只读的字符串connection，以后可用于连接数据库
            //思考Respoitory应该是static类还是实例类更好
            //考虑求助（Problem）的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
            //Publish()：发布一篇求助，并将其保存到数据库
            //Load(int Id)：根据Id从数据库获取一条求助
            //Delete(int Id)：根据Id删除某个求助
            //repoistory：可用于在底层实现上述方法和数据库的连接操作等
            //设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
            //想一想，为什么Publish()方法不是放置在User类中呢？用户（user）发布（Publish）一篇文章（article），不正好是user.Publish(article)么？
            //自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
            //出栈Pop()，弹出栈顶数据
            //入栈Push()，可以一次性压入多个数据
            //出 / 入栈检查，
            //如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
            //如果已弹出所有数据，提示“栈已空”
            //MimicStack mimicStack1 = new MimicStack();
            //mimicStack1.Push(1);
            //mimicStack1.Push(2);
            //mimicStack1.Push(3);
            //mimicStack1.Push(4);
            //mimicStack1.Push(5);
            ////mimicStack1.Push(6);//溢出
            //mimicStack1.Pop();
            //mimicStack1.Pop();
            //mimicStack1.Pop();
            //mimicStack1.Pop();
            //mimicStack1.Pop();
            //mimicStack1.Pop();



            #endregion


            //C#-面向对象：被多少人误解的继承？20201026   https://zhuanlan.zhihu.com/p/92535455
            #region   //作业
            //1、让User类无法被继承
            //2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
            //  1、Content中有一个字段：kind，记录内容的种类（problem / article / suggest等），只能被子类使用
            // 2、确保每个Content对象都有kind的非空值
            // 3、Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
            // 4、其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
            //3、实例化文章和意见建议，调用他们：
            // 1、继承自父类的属性和方法
            // 2、自己的属性和方法
            //4、再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，
            //包含一个只读的Id属性。试一试，Suggest能有Id属性么？
            //Article a1 = new Article();
            //a1.Agree();// // 1、继承自父类的属性和方法
            //a1.Search("123");// 2、自己的属性和方法



            #endregion
            //C#-面向对象：你真的明白什么是多态吗  20201027 ?https://zhuanlan.zhihu.com/p/93053223
            #region 
            //作业：
            //添加一个新类ContentService，其中有一个发布（Publish()）方法：
            //如果发布Article，需要消耗一个帮帮币
            //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
            //如果发布Suggest，不需要消耗帮帮币
            //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine()代替。根据我们学习的继承和多态知识，实现上述功能。

            //Article ch = new Article();
            //new ContentService().Publish(ch);
            //Problem p1 = new Problem("body");
            //new ContentService().Publish(p1);
            //Suggest s1 = new Suggest();
            new ContentService().Publish();
            Problem problem = new Problem("body")
            {
                Author = new User { Name = "feige" },
                Reward = 10
            };
            problem.Publish();


            //
            Article ch = new Article()
            {
                Title = "",
                Author = new User()
            };













            ///




            #endregion


            //C#-面向对象：抽象类和接口 20201027 https://zhuanlan.zhihu.com/p/93224519
            #region
            //思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。
            //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/ 踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
            //引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），用Console.WriteLine()实现Send()。
            //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。假设User类同时继承了ISendMessage和IChat，如何处理？
            #endregion
            //C#-面向对象-结构和日期  20201029 https://zhuanlan.zhihu.com/p/94590192
            #region
            //作业：
            // 用代码证明struct定义的类型是值类型
            //源栈的学费是按周计费的，所以请实现这两个功能：
            //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
            // 给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
            Bed bed;//结构变量 //值类型
            bed.id = 14;
            Console.WriteLine(bed.id);//14
            Bed bed0 = new Bed();//new Bed()实际上给所有struct成员赋了默认值
            Console.WriteLine(bed0.id);//0

            //Bed1 bed1;
            //bed1.id = 14;//报错：使用了未赋值的变量  //Bed1引用类型
            //Console.WriteLine(bed1.id);
            Bed1 bed11 = new Bed1();
            bed11.id = 14;
            Console.WriteLine(bed11.id);//14
            //Console.WriteLine(DateTime.Now.DayOfWeek);//周几
             //GetDate(); //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
            //string datetime = "2011-3-4";
            //Console.WriteLine((DateTime.Parse(datetime)).DayOfWeek);//在c#中，如何给定一个日期，求出该日为星期几？     
            GetDateWeek(2019);
            #endregion

            //C#-面向对象-不一样的权限管理：枚举和位运算 2020111 https://zhuanlan.zhihu.com/p/94590467
            #region
            /*声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
              声明一个令牌管理（TokenManager）类：
             使用私有的Token枚举_tokens存储所具有的权限
              暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
              User类中添加一个Tokens属性，类型为TokenManager*/
            Console.WriteLine("枚举");
            User user = new User();
            user.Tokens.Add(Token.Blogger);
           

        }



        #endregion





        /// <summary>
        ///  //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
        /// </summary>
        public static void GetDate()
        {
            //a = Console.ReadLine();
            //a.DayOfWeek;
            Console.WriteLine("请输入计算时间");
            DateTime putTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("你要进行什么计算，日计算选择d,周计算选择w,月计算选择m");
            string select = Console.ReadLine();
            switch (select)
            {
                case "d":
                    Console.WriteLine("请输入几月");
                    var nextTimeD = putTime.AddDays(int.Parse(Console.ReadLine()));
                    Console.WriteLine(nextTimeD);
                    break;
                case "w":
                    Console.WriteLine("请输入几周");
                    var nextTimeW = putTime.AddDays(int.Parse(Console.ReadLine()) * 7);
                    Console.WriteLine(nextTimeW);
                    break;
                case "m":
                    Console.WriteLine("请输入几月");
                    var nextTimeM = putTime.AddMonths(int.Parse(Console.ReadLine()));
                    Console.WriteLine(nextTimeM);
                    break;
                default:
                    break;
            }




        }
        /// <summary>
        /// 给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
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

            return dt;

        }
        public static void GetDateWeek(int year)
        {
            GetWeekBody(GetDate(year));
        }
        public static void GetWeekBody(DateTime dateTime)
        {
            int i = 1;
            int year = dateTime.Year;
            while (dateTime.Year == year)
            {
                Console.WriteLine($"第{i}周：{dateTime.ToString("yyyy年MM月dd日")}-{dateTime.AddDays(7).ToString("yyyy年MM月dd日")}");
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



