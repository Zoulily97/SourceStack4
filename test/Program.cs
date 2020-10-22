using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        //栈，堆
        public class Student
        {
           

            public Student(string name1, int age)
                : this(name1)   // 使用this()调用构造函数 1
            {
                this.age = age;
                Console.WriteLine($"hello {name},你的年龄是{age}");
            }


            public Student()
            {
                Console.WriteLine("hello");
            }
            public Student(string name)
            {
                this.name = name;//调用构造函数生成的对象Student zdh = new Student("周丁浩");  对象的字段赋值
                //this是只读（readonly）的、不能赋值的。
                //_name = name;
                Console.WriteLine($"hello{name}");

            }
            //private string name;
            public readonly string name;
            private int age;
        }
        static void Main(string[] args)
        {


            //
            Student lzb = new Student();
            Student zdh = new Student("周丁浩");
            Student zdh1 = new Student("周丁浩",25);
           // Console.WriteLine(zdh1.)
            Console.ReadKey();






            //    while (true)
            //    {
            //        int i = 100;
            //        i++;
            //        Console.WriteLine();
            //    }
            //    A();
            //}
            //static void A()
            //{
            //    int m = 10;
            //    int bResult = B(m);
            //    bResult++;
            //}
            //static int B(int m)
            //{
            //    int n = 20;
            //    int cResult = C(n);
            //    cResult++;
            //    return cResult;
            //}
            //static int C(int n)
            //{
            //    n++;
            //    return n;

            
        }
    }
}
