using System;

namespace 函数
{
    class Program
    {
        static void buy(params string[] water)
        {
            for (int i = 0; i < water.Length; i++)
            {
                Console.WriteLine(water[i]);
            }

        }

        static void grow(out int a)
        {
            a = 0;//out a赋值
            a++;
        }
        static void Main(string[] args)
        {
            // buy(new string[] { "可乐", "牛奶", "冰红茶" });
            buy( "可乐", "牛奶", "冰红茶" );

            //int age;
            //grow( out age);
            grow(out int age);//简写;
            if (double.TryParse(Console.ReadLine(), out double input))//能够parse
            {
                input += 10;
            }
            else
            {
                Console.WriteLine("输入有误");


                Console.WriteLine(age);



                //Console.WriteLine(find(ids, 23));

                int[] ids = { 21, 7, 19, 10, 23, 43, 15 };
                // quickSort(ids);


                // getFlbonac(0, 1);
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


            //快速排序  递归
            static void quickSort(int[] array, int left, int right)
            {
                //第一轮排序，获得中间值（及其下标）
                //int left = 0;
                int oldleft;
                int middleValue = array[left];
                int middle = 0;
                ////从右往左进行比较
                //int right = array.Length - 1;
                while (array[right] > middleValue)
                {
                    right--;

                }
                swap(array, middleValue, array[right]);
                while (array[left] < middleValue)
                {
                    right++;
                }
                swap(array, middleValue, array[left]);

                //左边排序
                quickSort(array, left, middle - 1);
                //int middleValue1 = array[0];
                //int right1 = right - 1; 
                //while (array[right] > middleValue)
                //{
                //    right--;
                //}
                //swap(array, middleValue, right);
                //右边排序

                quickSort(array, middle + 1, left);
                //int middleValue2 = array[0];
                //int right2 = right - 1;
                //while (array[right] > middleValue)
                //{
                //    right--;
                //}


            }

            /// <summary>
            /// 交换
            /// </summary>
            /// <param name="array"></param>
            /// <param name="middleValue"></param>
            /// <param name="right"></param>
            static void swap(int[] array, int middleValue, int right)
            {
                int temp = array[middleValue];
                array[middleValue] = array[right];
                temp = array[right];

            }







            /// <summary>
            /// 递归斐波拉契
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            static void getFlbonac(int a, int b)
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
}
