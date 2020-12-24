using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoeTest
{
    public class Email:Entity
    {
        public string EmailLocation { set; get; }
        public string Remark { set; get; }
        //public int? EmailAuthorId { set; get; }
        public User EmailAuthor { set; get; }
    }
}
