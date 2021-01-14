using SRV.ProdService;
using ServiceInterface;
using SRV.ViewModel.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YQBangMVC.Helpers;

namespace YQBangMVC.Controllers
{
    public class ArticleController : Controller
    {

        private IArticleService articleService;
        private IUserService userService;
        public ArticleController()
        {
            articleService = new ArticleService();
            userService = new UserService();
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
            //bool HasUserId = int.TryParse(Request.Cookies[Keys.User].Value, out int currentUserId);//有没有找到当前cookie，找到了当前currentUserId是什么
            //if (HasUserId)
            //{
            //    string pwd = userService.GetPwdById(currentUserId);
            //    if (Request.Cookies[Keys.User].Values[Keys.Password]!=pwd)
            //    {
            //        throw new ArgumentException("");

            //    } 
            //    int id= articleService.Publish(model, currentUserId);

            //}//else

            int articleId = articleService.Publish(model, CookieHelpers.GetCurrentUserId());
            return RedirectToAction("Single", new { id = articleId });
        }
        public ActionResult Single(int id)
        {
            SingleModel model = articleService.GetById(id);
            return View(model);
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}