using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        public class Person {
            public Person()
            {

            }
            public Person(string name)
            {
            }

            public Person(int age)
            {

            }
            public string Name
            {
                get;set;
            }
            protected /*internal*/ int Age { get; set; }//
            public void eat()
            {
                Console.WriteLine("吃饭");
            }


        }
        //栈，堆
        //public class Student:Person
        //{
           

        //    public Student(string name1, int age)
        //        : this(name1)   // 使用this()调用构造函数 1
        //    {
        //        this.age = age;
        //        Console.WriteLine($"hello {name},你的年龄是{age}");
        //    }
           

        //    //public Student()
        //    //{
        //    //    Console.WriteLine("hello");
        //    //}
        //    //public Student(string name)
        //    //{
        //    //    this.name = name;//调用构造函数生成的对象Student zdh = new Student("周丁浩");  对象的字段赋值
        //    //    //this是只读（readonly）的、不能赋值的。
        //    //    //_name = name;
        //    //    Console.WriteLine($"hello{name}");

        //    //}
        //    //private string name;
        //    public readonly string name;
        //    private int age;
        //}



        public class Student : Person
        {
            //子类必须显式地指明调用父类的某一个构造函数
            public Student():base("")
                //使用base关键字，将子类实例化获得的name传递给父类
            {

            }
            public Student (string name,int age):base(age)
            {

            }
            public void Exam()
            {
                Age++;
            }
            public int classId = 20;
        }

        public class OnlineStudent : Student
        {
            public OnlineStudent(int id,string name,int age):base(name, age)
            {

            }
        }

        static void Main(string[] args)
        {
            Person lw = new Student();
            lw.Name = "刘伟";
            //lw.classId;//取不到
            Console.WriteLine(((Student)lw).classId);//将lw强制类型转换为student类型
            Console.WriteLine(lw is Student);//true

            Person wx = null;
            Console.WriteLine(wx is Person);      //false：wx是null值

            Person pzq = new Person();
            //pzq是一个Person对象，无法转换成Student
            if (pzq is Student)//第一种判断
            {
                Console.WriteLine(((Student)pzq).classId);
            }
            else
            {
                Console.WriteLine("不能转换");
            }
            //无法将类型为“Person”的对象强制转换为类型“Student”。

            //第二种判断此外我们还有另一种方式，直接使用  as
            //进行转换。如果转换不成功，会返回null值。
            Student converted = pzq as Student;
            if(converted != null)
            {
                Console.WriteLine(converted.classId);
            }
            else
            {
                Console.WriteLine("不能转换");
            }


            new OnlineStudent(79, "12", 17);
            //  Student lzb = new Student();
            //  Student zdh = new Student("周丁浩");
            //Student zdh1 = new Student("周丁浩",25);
            // Console.WriteLine(zdh1.)


            Person zs = new Person(48);
            //Console.WriteLine(zs.Age);//protected子类中可使用，外部不能访问



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
