﻿using System;
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
            //Random r = new Random();
            //string str = null;
            //for (int i = 0; i < 5; i++)
            //{
            //    str += r.Next(0, 9);
            //}
            Random r = new Random();
            char[] constant =
        {
        '0','1','2','3','4','5','6','7','8','9',
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
         };

            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(62);

            //随机字符串
            for (int i = 0; i < 5; i++)
            {
                newRandom.Append(constant[r.Next(0, 62)]);
            }
            ////画验证码
            ///
            FontFamily myFontFamily1 = new FontFamily("幼圆");
            FontFamily myFontFamily2 = new FontFamily("微软雅黑");
            FontFamily myFontFamily3 = new FontFamily("等线");

            FontFamily[] fontFamily = { myFontFamily1, myFontFamily2, myFontFamily3, myFontFamily3, myFontFamily1 };
            Color[] color = { Color.DarkSlateGray,Color.DarkCyan, Color.Black,Color.Chartreuse, Color.White, Color.Red, Color.LightGreen, Color.Aquamarine, Color.BurlyWood, Color.DarkRed };
            int a = 20;
            for (int i = 0; i < 5; i++)
            {
                a += 20;
                g.DrawString(newRandom[i].ToString(),            //绘制字符串
                      new Font(fontFamily[r.Next(0, 3)], 24), //指定字体
                      new SolidBrush(color[r.Next(0, 10)]),      //绘制时使用的刷子
                      new PointF(a, 20)//左上角定位
                  );
            }
            for (int i = 0; i < 200; i++)
            {
                image.SetPixel(r.Next(0, 200), r.Next(0, 100), color[r.Next(0, 7)]); //绘制色素点


            }
            for (int i = 0; i < 10; i++)
            {//绘制线条
                g.DrawLine(new Pen(color[r.Next(0, 10)]), new Point(r.Next(0, 100), r.Next(10, 50)), new Point(r.Next(50, 200), r.Next(50, 100)));  //混淆用的直线（或曲线）
            }
            Console.WriteLine(newRandom[0]);

            image.Save(@"C:\Users\zouzou\Pictures\Screenshots\code2.jpg", ImageFormat.Jpeg);
        }
    }
}
