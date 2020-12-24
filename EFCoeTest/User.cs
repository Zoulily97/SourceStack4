using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoeTest
{
    public class User:Entity
    {
      //  public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int HelpMoney { get; set; }
        public int FailedTry { get; set; }
        public DateTime CreateTime { get; set; }

        public int ? SendToId { get; set; }
        public Email SendTo { set; get; }







    }
}
