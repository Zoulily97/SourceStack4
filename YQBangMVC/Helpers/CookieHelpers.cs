using ServiceInterface;
using SRV.ProdService;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace YQBangMVC.Helpers
{
    public class CookieHelpers
    {
        private IUserService userService;
      
        public CookieHelpers()
        {

            userService = new UserService();
        }
        public static  int? GetCurrentUserId()
        {
            //MVC HttpContext.Current拿到当前HttpContext上下文
            NameValueCollection userInfo =HttpContext.Current.Request.Cookies[Keys.User].Values;
            if (userInfo == null)
            {
                return null;
            }
            bool hasUserId = int.TryParse(userInfo[Keys.Id], out int currentUserId);
            if (!hasUserId)
            {
                throw new ArgumentException("");
            }
            string pwdInCookie = userInfo[Keys.Password];
            if (string.IsNullOrWhiteSpace(pwdInCookie))
            {
                throw new ArgumentException("");
            }
            // string pwd = "";
            string pwd = new UserService().GetPwdById(currentUserId);
            if (pwd != pwdInCookie)
            {
                throw new ArgumentException();
            }
            return currentUserId;
        }
    }
}