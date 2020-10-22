using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            float result = a / b;
            float result1 = (float)a / b;
            Console.WriteLine("int a = 3 int b = 2 " );
            Console.WriteLine("a / b"+a + b);
            Console.WriteLine("a / b;"+result);
            Console.WriteLine("(float)a / b"+result1);
            float result2 = 3 + 2 / 5;
            Console.WriteLine("3 + 2 / 5" + result2);
            double result3 = 0.1 + 0.2;
            Console.WriteLine(" 0.1 + 0.2;" + result3);
            bool result4 = a > b;
            Console.WriteLine("a > b"+result4);
            bool result5 = (0.1 + 0.2) == 0.3;
            Console.WriteLine("(0.1 + 0.2) == 0.3"+result5);
            string name = "源站";

            Console.WriteLine("你好，！源栈，欢迎您");
            Console.WriteLine($"你好，！源栈，欢迎您");



        }
    }
}
