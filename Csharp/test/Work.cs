using System;
using System.Text;

namespace Csharp.作业
{
    /// <summary>
    /// 
    /// </summary>
    public class Work
    {

        public static void Excute()
        {

            int a = 6;
            int b = 3;
            Console.WriteLine("输出两个整数的和/差/积/商");
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            float c = 5.3F;
            float d = 3.2F;
            Console.WriteLine("输出两个小数的和/差/积/商");
            Console.WriteLine(c + d);
            Console.WriteLine(c - d);
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);

            //--2
            Console.WriteLine("---电脑计算并输出：[(23+7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）---");
            int e = 23, f = 7, g = 12, h = 8, m = 6;
            decimal result = (decimal)((e + f) * g - h) / m;
            Console.WriteLine(decimal.Round(result, 2));

            //--3
            Console.WriteLine("想一想以下语句输出的结果：");
            int i = 15;
            Console.WriteLine(i++);//15
            i -= 5;    // i=16
            Console.WriteLine(i);//11
            Console.WriteLine(i >= 10);//true
            Console.WriteLine("i值的最终结果为：" + i);

            //--4
            int j = 20;
            Console.WriteLine($"{i}+{j}={i + j}");
            Console.WriteLine("想一想如下代码的结果是什么，并说明原因");
            int k = 10;
            Console.WriteLine(k > 9 && (!(k < 11) || k > 10));//false
            Console.WriteLine("--1  且---0-|--1-------或---0-----");
            int a1 = 10;

            //--5
            //当a为何值时，结果为true？
            bool result1 = (a1 + 3 > 12) && a1 < 3.14 * 4 && a1 != 11;
            Console.WriteLine(result1);
            Console.ReadKey();
        }

        public  static void Login()
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
        // 4、实现 int GetCount(string container, string target)方法，可以统计出container中有多少个target
        public static int GetCount(string container, string target)
        {

            // 方法2 
            //return Regex.Matches(container, target).Count;

            int result = 0;
            while (container.Contains(target))
            {
                container = container.Substring(container.IndexOf(target) + target.Length);
                // Console.WriteLine(container);
                result += 1;
            }

            return result;
        }

        // 5、不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，
        //比如：mimicJoin("-", "a", "b", "c", "d")，其运行结果为：a - b - c - d*/

        public static string MimicJoin(string separator, string[] value)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                sb = sb.Append(value[i]);//a
                if (i != value.Length - 1)
                {
                    sb.Append(separator);
                }

            }
            return sb.ToString();


        }
    }
}
