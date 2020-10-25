using System;

namespace test
{

    // 20201025  C#-面向对象：静态还是实例？
    //https://zhuanlan.zhihu.com/p/95261748
    public class Cat
    {
        public static string Belong { get; set; } = "哺乳动物";
        private string name;
        static Cat()
        {

        }
        public Cat(string name)
        {
            this.name = name;
        }
    }
    public static class Punish
    {
        //静态类不能被实例化，其中只能有静态成员，不能有实例成员。
        static Punish()
        {

        }
        static void Do()
        {

        }
    }
}

namespace test
{
    class Program
    {
        //栈，堆
        public class Student
        {
            //用一个静态数组存放所有入栈学生
            public static Student[] students = new Student[18];
            //要逐渐习惯使用简单类型以外的自定义类型
            internal static void enroll(Student newbie)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    //找到一个为null值的“空位”
                    if (students[i] == null)
                    {
                        //把新同学放到空位中
                        students[i] = newbie;
                        return;
                     

                    }

                }
              
            }



            private double[] scores = new double[10];
            public double this[int index]
            {
                get { return scores[index - 1]; }
                set { scores[index - 1] = value; }
            }
            public double Score
            {
                get => new Random().Next();
            }

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
            Student.enroll(new Student("1112"));
            








            Cat fllower = new Cat("小花");
            Cat miao = new Cat("喵喵");



            Student zdh2 = new Student();
            zdh2[1] = 98.5;
            zdh2[2] = 99;
            Console.WriteLine(zdh2[2]);
            //"指向"一个对象的变量

            var zjq = new  /*注意：没有类名了*/
            {
                Name = "曾俊清",
                Age = 23,
            };
            Console.WriteLine(zjq.Name);




            //
            Student lzb = new Student();
            Student zdh = new Student("周丁浩");
            Student zdh1 = new Student("周丁浩", 25);
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
