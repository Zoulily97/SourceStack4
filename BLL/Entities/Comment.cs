using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
  public  class Comment:BaseEntity
    {
        public Article Article { get; set; }
        public string Content { get; set; }
        public string Reply { get; set; }
    }
}
