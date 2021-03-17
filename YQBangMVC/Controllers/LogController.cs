using SRV.ProdService;
using ServiceInterface;
using SRV.ViewModel;
using SRV.ViewModel.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Global;

namespace YQBangMVC.Controllers
{
    public class LogController : Controller
    {

        private IUserService userService;
        public LogController()
        {
            userService = new UserService();
        }
        // GET: Log
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult On()
        {
            return View();
        }
        [HttpPost]
        public ActionResult On(LogOnModel model)
        {
            // bool result = userService.GetByName(model.Name, out string pwd);//面向过程 //扩展性不够
            UserModel user = userService.GetByName(model.Name);//这个UserModel不能对应一个View

            if (user == null)
            {
                ModelState.AddModelError("", "用户名不存在");
                return View();

            }
            if (user.Password != model.Password)
            {
                ModelState.AddModelError("", "密码错误");
                return View();
            }
            HttpCookie cookie = new HttpCookie(Keys.User);
            cookie.Values.Add(Keys.Id, user.Id.ToString());
            cookie.Values.Add(Keys.Password, user.Password.MD5Crypt());
            if (model.Rememberme)
            {
                cookie.Expires = DateTime.Now.AddDays(1);
            }

            Response.Cookies.Add(cookie);
            return RedirectToAction("Index", "Home");
        }
    }
}