
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EFCoeTest
{
    public class Article: Content
    {
        public IList<Comment> Comments { get; set; }
        public IList<Keyword> Keywords { get; set; }
        public string Series { set; get; }//系列
       
        //public override void Publish()
        //{
        //    //base.Publish();
        //    HelpMoney--;
        //}

    }
}
