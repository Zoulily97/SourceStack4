using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verification_Code
{
    class Program
    {
        #region
        //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
        //随机字符串
        //混淆用的各色像素点
        //混淆用的直线（或曲线）
        #endregion
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);

            //随机字符串
            Random r = new Random();
            string str = null;
            for (int i = 0; i < 5; i++)
            {
                str += r.Next(0, 9);
            }
            ////画验证码
            ///
            FontFamily myFontFamily1 = new FontFamily("幼圆");
            FontFamily myFontFamily2 = new FontFamily("微软雅黑");
            FontFamily myFontFamily3 = new FontFamily("等线");

            FontFamily[] fontFamily = { myFontFamily1, myFontFamily2, myFontFamily3, myFontFamily3, myFontFamily1 };
            Color[] color = { Color.DarkSlateGray, Color.White, Color.Red, Color.LightGreen, Color.Aquamarine, Color.BurlyWood, Color.DarkRed };
            int a = 20;
            for (int i = 0; i < 5; i++)
            {
                a += 20;
                g.DrawString(str[i].ToString(),            //绘制字符串
                      new Font(fontFamily[r.Next(0, 3)], 24), //指定字体
                      new SolidBrush(color[r.Next(0, 7)]),      //绘制时使用的刷子
                      new PointF(a, 20)//左上角定位
                  );
            }
            for (int i = 0; i < 200; i++)
            {
                image.SetPixel(r.Next(0, 150), r.Next(0, 100), color[r.Next(0, 7)]); //绘制色素点


            }
            for (int i = 0; i < 20; i++)
            {
                g.DrawLine(new Pen(color[r.Next(0, 7)]), new Point(r.Next(0, 100), r.Next(0, 100)), new Point(r.Next(0, 50), r.Next(50, 100)));  //混淆用的直线（或曲线）
            }
            Console.WriteLine(str[0]);

            image.Save(@"C:\Users\zouzou\Pictures\Screenshots\code2.jpg", ImageFormat.Jpeg);
        }
    }
}
