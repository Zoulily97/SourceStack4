using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E = SourceStack.Entities;
using SourceStack.Repository;

namespace SourceStack.Pages.Article
{
    public class IndexModel : PageModel 
    {
        private ArticleRepository ArticleRepository;
        public IndexModel()
        {
            ArticleRepository = new ArticleRepository();
        }
        public IList<E.Article> Articles { get; set; }
        public int sumofArticles { get; set; } 
        public void OnGet()
        {
            if (!string.IsNullOrEmpty(Request.Cookies[Keys.UserId])) {
                ViewData["HasLogOn"] = true;
            }


            sumofArticles = ArticleRepository.ArticleCount;
            //int pageIndex = Convert.ToInt32(Request.Query["pageIndex"][0]);
            int pageIndex = Convert.ToInt32(RouteData.Values["id"]);
            Articles = ArticleRepository.Get(pageIndex,3);
           
        }
    }
}
