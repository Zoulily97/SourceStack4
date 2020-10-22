using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_test
{
    class Program
    {
        static void Main(string[] args)
        {
           /*观察一起帮登录页面，用if...else...完成以下功能。
            用户依次由控制台输入：验证码、用户名和密码：
            如果验证码输入错误，直接输出：“* 验证码错误”；
            如果用户名不存在，直接输出：“* 用户名不存在”；
            如果用户名或密码错误，输出：“* 用户名或密码错误”
            以上全部正确无误，输出：“恭喜！登录成功！”
           PS：验证码/用户名/密码直接预设在源代码中，输入由Console.ReadLine()完成。*/


            Console.WriteLine("请输入验证码");
            string  yanzhan=Convert.ToString(Console.ReadLine());
            Console.WriteLine("请输入用户名");
            string username = Convert.ToString(Console.ReadLine());
            if (yanzhan == "1234" && username == "zl")
            {
                Console.WriteLine("欢迎"+username+"登录成功！");
            }
            else
            { 
                if(yanzhan == "1234")
            {
                    Console.WriteLine("验证码输入正确");
                }
            else
                {
                    Console.WriteLine("验证码输入错误");

                }
             if (username == "zl")
                {
                    Console.WriteLine("用户名正确");
                }
                else
                {
                    Console.WriteLine("用户名输入错误");

                }
            }

            Console.ReadKey();



        }
    }
}
