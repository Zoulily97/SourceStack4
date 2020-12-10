using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Filters;
using SourceStack.Repository;
using E = SourceStack.Entities;

namespace SourceStack.Pages.Article
{
  //  [IsShowLogOn]//  Ò³ÃæÏÔÊ¾µÇÂ¼×´Ì¬
    public class SingleModel : PageModel
    {
        private ArticleRepository ArticleRepository;
        public E.Article Article { get; set; }
        public string PreTitle { get; set; }
        public int PreID { get; set; }
        public int NextID { get; set; }
        public string NextTitle { get; set; }
        public int MaxPageId { get; set; }


        public SingleModel()
        {
            ArticleRepository = new ArticleRepository();

        }

        public void OnGet()
        {

            //if (!string.IsNullOrEmpty(Request.Cookies[Keys.UserId])) {
            //    ViewData["HasLogOn"] = true;
            //}


            // int id = Convert.ToInt32(Request.Query["id"][0]);
            int id = Convert.ToInt32(RouteData.Values["id"]);
            //PreID = id - 1;
            //NextID = id + 1;
            if (id > 1) {
                PreTitle = ArticleRepository.Find(id - 1).Title;
            }
            Article = ArticleRepository.Find(id);
            if (id <ArticleRepository.ArticleCount) {
                NextTitle = ArticleRepository.Find(id + 1).Title;
            }

            ViewData["AgreeCount"] = 3;
        }
    }
}
