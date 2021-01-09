using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
  public static class StringExtension  //扩展方法，不修改原有类，在原有类，另外声明一个扩展类
    {
       public  static string MD5Crypt(this string source)//静态方法，第一个参数是原有类型string 参数忽略
        {
            byte[] bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(source));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2"));

            }
            //return Encoding.UTF8.GetString(bytes);
            return sb.ToString();
        }
    }
}
