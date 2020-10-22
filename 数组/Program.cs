using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {



            //二分查找
            int[] Ids = { 8, 2, 3, 4, 15, 6, 17 };
            int target = 4;
            int left = 0;
            int right = Ids.Length - 1;
            int  mid;
            bool result = false;
            while (left <= right)
            {
                 mid = (left + right) / 2;
                if (Ids[mid] == target)
                {
                    result = true;

                }
                else if (Ids[mid] < target)
                {
                    left = mid + 1;
                }
                else if (Ids[mid] > target)
                {
                    right = mid - 1;
                }
                if (result)
                {
                    Console.WriteLine(Ids[mid] + "找到了" + "位置在第" + (mid + 1) + "位");
                    // Console.WriteLine("找到了");
                    break;
                }
                //else if (!result)
                //{
                //    Console.WriteLine("没有找到");
                //}
            }
            //if (result)
            //{
            //    Console.WriteLine( "找到了位置在第 位");
            //    // Console.WriteLine("找到了");
            //   // break;
            //}

            Console.ReadKey();











            //冒泡排序
            //冒泡排序属于一种典型的交换排序。
            //交换排序顾名思义就是通过元素的两两比较，
            //判断是否符合要求，如过不符合就交换位置来达到排序的目的。
            //冒泡排序名字的由来就是因为在交换过程中，类似水冒泡，
            //小（大）的元素经过不断的交换由水底慢慢的浮到水的顶端。

            //循坏，外面再套一层循环

            //int[] studentId = { 8, 2, 3, 4, 15, 6, 17 };

            //for (int i = 0; i < studentId.Length; i++)
            //{
            //    //从小到大
            //    for (int j = 0; j < studentId.Length-1; j++)
            //    {
            //        if (studentId[j] > studentId[j + 1])
            //        {
            //            int temp = studentId[j];
            //            studentId[j] = studentId[j + 1];
            //            studentId[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < studentId.Length; i++)
            //{
            //    Console.WriteLine(studentId[i]);
            //}

            /*  int[] studentId = { 8, 2, 3, 4, 15, 6, 17 };

              for (int i = 1; i < studentId.Length; i++)
              {
                  //从小到大
                  for (int j = 0; j < studentId.Length-i; j++)
                  {
                      if (studentId[j] > studentId[j + 1])
                      {
                          int temp = studentId[j];
                          studentId[j] = studentId[j + 1];
                          studentId[j + 1] = temp;
                      }
                  }
              }
              for (int i = 0; i < studentId.Length; i++)
              {
                  Console.WriteLine(studentId[i]);
              }*/









            /*//求最大/小值   
            int[] studentId = { 8, 2, 3, 4, 15, 6, 17 };
            int min = studentId[0];
            for (int i = 1; i <studentId.Length; i++)
            {
                if (studentId[i] < min)
                {
                    min = studentId[i];
                }
                //else { }
            }
            Console.WriteLine(min);*/



            //循环示例 求累加
            //int sum=0;
            //for (int i = 0; i < 5; i++)
            //{
            //    sum += i;

            //}
            //Console.WriteLine(sum);

            /*  int[] studentId = { 1, 2, 3, 4, 5, 6, 7 };
              int sum = 0;
              for (int i = 0; i < studentId.Length; i++)
              {
                  sum += studentId[i];

              }
              Console.WriteLine(sum);*/










            //在数组中查找某个值,找到10；找到输出找到位置，找不到输出，找不到
            //int[] studentId = { 2, 4, 5, 6, 10, 7, 76 };
            ////遍历(穷举）
            ////bool found = false;//额外声明一个bool变量，判断有没有找到  found = false 没有找到
            //for (int i = 0; i < studentId.Length; i++)
            //{
            //    if (studentId[i] == 10)
            //    {
            //        Console.WriteLine("找到了，位置在" + (i+1)+ "位");
            //        break;
            //        //found = true;
            //    }
            //    else
            //    {
            //        if (i == studentId.Length - 1)
            //        {
            //            Console.WriteLine("没有找到");
            //        }

            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine("没有找到");
            //    //}
            //}
            ////if (!found)//!found found没有找到
            ////{
            ////    Console.WriteLine("没有找到");
            ////}






            //while循环
            //  string[] student = { "lw", "wx", "lgy", "zl" };
            //int i = 0;
            //while (i < student.Length - 1)
            //{
            //    Console.WriteLine(student[i]);
            //    i++;
            //}
            //Console.ReadKey();


            ////do while 循环
            //string[] student = { "lw", "wx", "lgy", "zl" };
            //int i = student.Length - 1;
            //do
            //{
            //    Console.WriteLine(student[i]);
            //    i--;
            //} while (i > 0);
            //Console.ReadKey();

            ////for 循环
            //for (int i = 0; i < student.Length; i++)
            //{
            //    Console.WriteLine(student[i]);
            //}


        }

    }
}


