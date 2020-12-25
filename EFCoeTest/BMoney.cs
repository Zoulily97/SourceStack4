using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoeTest
{
   public  class BMoney:Entity
    {
        public DateTime LatestTime { get; set; }
        public string Type { get; set; }
        public int ChangeAmount { get; set; }
        public int Frozen { get; set; }
        public int Left { get; set; }
        public User Owner { get; set; }
        public string Remark { get; set; }//备注
        
    }
}
