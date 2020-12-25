using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoeTest
{
    public class User : Entity
    {
        
        public string Password { get; set; }
        public string Name { get; set; }
        public int FailedTry { get; set; }
        public DateTime CreateTime { get; set; }
        public int? SendToId { get; set; }
        public Email SendTo { set; get; }
        public IList<Article> Articles { get; set;}
        public IList<Problem> Problems { set; get; }
        public IList<BMoney> Wallet { get; set; }
        public IList<Message> Messages { get; set; }







    }
}
