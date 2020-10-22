using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ids = { 1, 23, 4, 56, 6, 7 };
            //Console.WriteLine(find(ids, 23));

            getFlbonac(0, 1);
            Console.ReadKey();
        }
        static int find(int[] array, int target)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }


        //快速排序
        static void quickSort(int[] array)
        {
            int middle = array[0];
            //从右往左进行比较
            int right = array.Length - 1;
            while (true)
            {
                right--;

            }
                 
        }







        /// <summary>
        /// 递归斐波拉契
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static void getFlbonac(int a,int b)
        {
            //int init = 0, next = 1;
           // Console.WriteLine(a);
            Console.WriteLine(b);
            if (b > 10)//递归终止条件
            {
                return;
            }
                // 0,1=>1
                //1,2->3
                //
                //,,,
                //b,sum->b+sum
                int sum = a + b;
              //  Console.WriteLine(sum);
                getFlbonac(b, sum);  
               //return sum;
        }
        //
    }
}
