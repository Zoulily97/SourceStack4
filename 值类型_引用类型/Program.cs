using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace 值类型_引用类型
{
    public  class Program
    {
        

        public static void grow( Student student)
        {
            // student = new Student();
            student.age++;
            Console.WriteLine(student.age);
        }

        //public Student  grow( Student student)
        //{
        //    // student = new Student();
        //    student.age++;
        //    Console.WriteLine(student.age);
        //    return student;
        //}
        public  static void Main(string[] args)
        {
            //
            Student wx = new Student();
            wx.age = 18;
            Console.WriteLine("当前student");
            Console.WriteLine(wx.age);

            //值类型参数的值传递
            int i = 18;
            int j = i;
            Console.WriteLine(j);
            j = 19;
            Console.WriteLine(j);
            


            // 值类型参数的引用传递
            Student lw = new Student();
            lw.age = 18;
            Student clone = lw; //这里是把wx的什么赋值给了clone？
            clone.age = 20;
            Console.WriteLine(lw.age);
            //因为 Student clone = lw; 这一行代码，
            //实际上是把变量lw中存放的Student对象地址赋值给了clone，
            //从而让clone变量中也存放了lw的对象地址。通过&运算可以清楚的看到这一点：




            //引用类型参数的值传递
            Console.WriteLine("引用类型参数的值传递");
            Student zl = new Student();
            zl.age = 18;
            grow( zl);
            Console.WriteLine(zl.age);

  
            //引用类型参数的值传递
            //引用类型的值传递。这里是将变量zl的值 复制一份，将副本传递给grow()方法。
            //变量zl的值，它具体指的是什么？是 new Student()这个对象的地址
            //因为传递给grow()方法的是对象地址，所以在方法中修改的也就是对象内容，
            //而最后的输出的也是对象的内容（zl.age），所以……


            //
            //引用类型参数的引用传递
            //Console.WriteLine("引用类型参数的值传递");
            //Student zll = new Student();
            //zll.age = 18;
            //grow(/*ref*/ zll);
            //Console.WriteLine(zl.age);





            Console.ReadKey();

        }
    }
}
