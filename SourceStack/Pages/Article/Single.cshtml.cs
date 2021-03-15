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
    [IsShowLogOn]//  页面显示登录状态
    public class SingleModel : PageModel
    {
        private ArticleRepository articleRepository;
        public E.Article Article { get; set; }
        public string PreTitle { get; set; }
        public int PreID { get; set; }
        public int NextID { get; set; }
        public string NextTitle { get; set; }
        public int MaxPageId { get; set; }


        public SingleModel()
        {
            articleRepository = new ArticleRepository();

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

            //上一一个问题
            //if (id > 1) {
            //    PreTitle = articleRepository.Find(id - 1).Title;
            //}

            Article = articleRepository.Find(id);
            //下一个问题
            //if (id < articleRepository.ArticleCount()) {
            //    NextTitle = articleRepository.Find(id + 1).Title;
            //}

         //   Article.keywords = new KeywordRepository().FindArticle(Article.Id);
                //item.Comments=new CommentRepository().
            

            ViewData["AgreeCount"] = 3;
        }
    }
}
