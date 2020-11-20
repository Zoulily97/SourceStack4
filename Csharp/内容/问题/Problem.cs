using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    //考虑求助（Problem）的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
    public class Problem : Content 
    {
        //标题 内容 作者 关键字
        //crtl+r+e
        private string body;
        private int reward;
        private DateTime publishDateTime;     
        public string Body { get; set ; }
        //  3、problem.Reward不能为负数
        //为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的求助作者*/
        public int Reward
        {
            get => reward;
            set
            {
                //1、修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常
                if (value < 0)
                {
                    throw new  Exception("参数越界");
                }
                else
                {
                    reward = value;
                }
            }
        } 
        public DateTime PublishDateTime { get => publishDateTime; set => publishDateTime = value; }
        public Problem()
        {

        }

        public Problem(int a)
        {
            this.reward = a;

        }
        public static  void  Load(int Id)//根据Id从数据库获取一条求助
        {
            Id++;
        }
        public static void Delete(int Id)//：根据Id删除某个求助
        {
            Id--;
        }

        [HelpMoneyChanged(5)]
        public override void Publish()
        {
            Author.HelpMoney -= Reward;//发布减少帮帮比
           
            Reward--;//需要消耗其设置悬赏数量的帮帮币
        }

        
    }
}
