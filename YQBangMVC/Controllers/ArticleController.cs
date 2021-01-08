using ProdService;
using ServiceInterface;
using SRV.ViewModel.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YQBangMVC.Controllers
{
    public class ArticleController : Controller
    {

        private IArticleService articleService;
        public ArticleController()
        {
            articleService = new ArticleService();
        }
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        public ActionResult New(NewModel model)
        {
           // int currentUserId = 1;
            articleService.Publish(model/*, currentUserId*/);
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}