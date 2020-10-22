using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hanshu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ids = { 1, 23, 4, 56, 6, 7 };
          
            Console.WriteLine(find(ids,23));
            Console.ReadKey();
        }
        static int find(int[] array, int target)
        {

            for (int i = 0; i < array.Length -1; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
                   

            }
            return -1;
        }



    }
}
