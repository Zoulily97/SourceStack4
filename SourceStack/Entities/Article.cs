using SourceStack.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SourceStack.Entities
{
    public class Article: Content
    {
        public string Series { set; get; }
        public override void Publish()
        {
            //base.Publish();
            HelpMoney--;
        }

    }
}
