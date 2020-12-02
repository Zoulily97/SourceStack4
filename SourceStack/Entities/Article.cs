using SourceStack.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SourceStack.Entities
{
    public class Article: Entity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Keyword > keywords { get; set; }


    }
}
