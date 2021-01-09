using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ViewModel.Article
{
    public class SingleModel
    {
        
        public string Title { get; set; }
        public string PublishTime { get; set; }
        public string Body { get; set; }
        public IList<DayOfWeek> KeyWord { get; set; }
        public string AuthorName { get; set; }
    }
}
