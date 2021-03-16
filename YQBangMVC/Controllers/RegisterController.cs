using SRV.ProdService;
using ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Global;

namespace YQBangMVC.Controllers
{
    public class RegisterController : Controller
    {
        private IUserService userService;
        public RegisterController()
        {
            userService = new UserService();
        }
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            int userId = userService.Register(model);   
            HttpCookie cookie = new HttpCookie(Keys.User);
            cookie.Values.Add(Keys.Id, userId.ToString());
            cookie.Values.Add(Keys.Password,  model.Password.MD5Crypt());
            Response.Cookies.Add(cookie);//响应拿到cookie

            return RedirectToAction("on", "Log");
        }
    } 
}