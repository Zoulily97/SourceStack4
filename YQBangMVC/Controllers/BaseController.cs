using Global;
using ServiceInterface;
using SRV.ProdService;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YQBangMVC.Controllers
{
    public class BaseController:Controller
    {
        private IUserService userService;
        private IArticleService articleService;
        public BaseController()
        {

            articleService = new ArticleService();
            userService = new UserService();
        }

        //防御式编程
        //顺利拿到 返回； 拿不到返回null
        //1、Request.Cookies[Keys.User].Value  取出来
        protected int? GetCurrentUserId()//可空类型返回null
        {
            NameValueCollection userInfo = Request.Cookies[Keys.User].Values;
            if (userInfo==null)
            {
                return null;
            }
            bool hasUserId = int.TryParse(userInfo[Keys.Id], out int currentUserId);
            if (!hasUserId )
            {
                throw new ArgumentException("");
            }
            string pwdInCookie = userInfo[Keys.Password];
            if(string .IsNullOrWhiteSpace (pwdInCookie))
            {
                throw new ArgumentException("");
            }
            string pwd= userService.GetPwdById(currentUserId);
            if (pwd != pwdInCookie)
            {
                throw new ArgumentException();
            }
            return currentUserId;

             

            }
        }
    }
