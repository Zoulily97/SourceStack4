using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    class ArticleFactory
    {
        static internal void Create()
        {
            Article zs = New("zs");
            Article ls = New("ls");
            Article ws = New("ws");

        }
        private static Article New(string title)
        {
            const string body = "反正你都要“做”数据" + " 干嘛不把数据做得更好一些呢每次登陆都先去注册一次？或者先去数据库";

            Article article = new Article {
                Title = title,
                Body = body,
                Author = UserFactory.zs
            };
            ArticleRepository articleRepository  = new ArticleRepository(Helper.GetDbcontext());
            articleRepository.Save(article);
            return article;
        }
    }
}
