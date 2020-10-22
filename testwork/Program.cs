using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testwork
{
    class Program
    {
        static void Main(string[] args)
        {

            //作业：
            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //        将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //        找到100以内的所有质数（只能被1和它自己整除的数）
            //生成一个元素（值随机）从小到大排列的数组

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
            //    if(i%2!=0)
            //    Console.WriteLine(i);
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
            //    if(i % 2 != 0)
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //string[] studentname = { "刘伟", "李智博", "龚廷义", "廖光银", "周宁浩", "邹丽", "胡涛" };
            //for (int i = 0; i < studentname.Length - 1; i++)
            //{
            //    Console.WriteLine(studentname[i]);

            //}
            //string[,] location = new string[3, 4];
            //location[0, 1] = "刘伟";
            //location[0, 3] = "龚廷义";
            //location[1, 0] = "李智博";
            //location[1, 1] = "周宁浩";
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

            // 3-- 让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 99; i >= 0; i--)
            //{
            //    sum += i;
            //    i--;


            //}
            //Console.WriteLine(sum);//2500



            //--4 将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分





            //--5找到100以内的所有质数（只能被1和它自己整除的数）
            //定义：素数只能被1和它自身整除的数,1不是素数 (2是最小的素数)
            //思路： 求某个数N是不是素数？用for循环让N依次除以 从2~(N - 1)之间的数，
            // 如果能被整除，则N不是素数，反之则是。
            // 12345678910
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














            //--6生成一个元素（值随机）从小到大排列的数组





















            ////数组作业
            ////作业：
            ////将源栈同学姓名 / 昵称分别：
            ////按进栈时间装入一维数组，
            ////按座位装入二维数组，
            ////并输出共有多少名同学。
            //string[] studentname = { "刘伟", "李智博", "龚廷义", "廖光银", "周宁浩", "邹丽", "胡涛" };
            //int k;
            //for (k = 0; k < studentname.Length; k++)
            //{
            //}
            //Console.WriteLine("共有" + k + "名同学");

            //string[,] location = new string[3, 4];
            //location[0, 1]= "刘伟";
            //location[0, 3] = "龚廷义";
            //location[1, 0] = "李智博";
            //location[1, 1] = "周宁浩";
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
            Console.ReadKey();
            

        }

       
    }
}
