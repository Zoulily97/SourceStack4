using SRV.ViewModel.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterface
{
   public  interface  IArticleService
    {
        int Publish(NewModel model, int? currentUserId);
        SingleModel GetById(int id);
       // void Publish(NewModel model, int? currentUserId);
    }
}
