using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Message : BaseEntity
    {
        public bool Selected { get; set; }
        public DateTime CreateTime { get; set; }
        public string Content { get; set; }
        public bool HasRead { get; set; }

        public void Read()
        {
            HasRead = true;

        }
    }
}
