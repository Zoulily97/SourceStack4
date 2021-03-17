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
        private IRegisterService registerService;
        public RegisterController()
        {
            userService = new UserService();
            registerService = new RegisterService();
        }
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            RegisterModel inviter = registerService.GetByName(model.InviterName);
            if (inviter == null)
            {
                ModelState.AddModelError(nameof(model.InviterName), "邀请人是不是填错啦");
                return View(model);
            };
            if (inviter.InviterNumber != model.InviterNumber)
            {
                ModelState.AddModelError(nameof(model.InviterNumber), "邀请码是不是填错啦！");
                return View(model);
            }
            int userId = userService.Register(model);   
            HttpCookie cookie = new HttpCookie(Keys.User);
            cookie.Values.Add(Keys.Id, userId.ToString());
            cookie.Values.Add(Keys.Password,  model.Password.MD5Crypt());
            Response.Cookies.Add(cookie);//响应拿到cookie

            return RedirectToAction("on", "Log");
        }
    } 
}