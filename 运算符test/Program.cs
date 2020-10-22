using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 3;
            Console.WriteLine("输出两个整数的和/差/积/商");
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a /b);
            int c = 5;
            int d = 3;
            Console.WriteLine("输出两个小数的和/差/积/商");
            Console.WriteLine((float)c +d);
            Console.WriteLine((float)c - d);
            Console.WriteLine((float)c * d);
            Console.WriteLine((float)c / d);
            Console.WriteLine("---电脑计算并输出：[(23+7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）---");
            int e = 23, f = 7, g = 12, h = 8, m= 6;
            decimal result = (decimal)((e + f) * g - h) / m;
            Console.WriteLine(decimal.Round(result,2) );

            Console.WriteLine("想一想以下语句输出的结果：");
            int i = 15;
            Console.WriteLine(i++);//15
            i -= 5;    // i=16
            Console.WriteLine(i);//11
            Console.WriteLine(i >= 10);//true

            Console.WriteLine("i值的最终结果为：" + i);

            int j = 20;
            Console.WriteLine($"{i}+{j}={i + j}");
            Console.WriteLine("想一想如下代码的结果是什么，并说明原因");
            int k = 10;
            Console.WriteLine(k > 9 && (!(k < 11) || k > 10));//false
            Console.WriteLine("--1  且---0-|--1-------或---0-----");
            int a1 = 10;
            //当a为何值时，结果为true？
             bool result1 = (a1 + 3 > 12) && a1 < 3.14 * 4 && a1!= 11;
            Console.WriteLine(result1);
            Console.ReadKey();







        }
    }
}
