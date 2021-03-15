using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Repository;
using SourceStack.Entities;
using System.ComponentModel.DataAnnotations;
using SourceStack.ModelValidations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SourceStack.Filters;

namespace SourceStack.Pages.Log
{
    [BindProperties]
   // [IsShowLogOn]//  页面显示登录状态
    public class OnModel : PageModel
    {
        private UserRepository userRepository;
         public OnModel()
        {
            userRepository = new UserRepository();
        }

        [Required(ErrorMessage = "密码不能为空")]
        [Display(Name = "密码")]
      //  [Password]
        public string Password { get; set; }

        [Required(ErrorMessage = "用户名不能为空")]
        public string Name { get; set; }

        public bool Remember { get; set; }
        private ModelStateDictionary errorinPost;//声明一个变量
        public void OnGet()
        {
            ////cookie来确认当前用户的登录状态：
            //if (!string.IsNullOrEmpty(Request.Cookies[Keys.UserId])) {
            //    ViewData["HasLogOn"] = true;
            //}

            //3. 从TempData里取出Error信息
            Dictionary<string, string> errors = TempData[Keys.ErrorInfo] as Dictionary<string, string>;
            if (errors != null) {
                //4. 将Error信息添加到ModelState 
                foreach (var item in errors)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }
            }


            // ModelState.Merge(errorinPost);---
            // Remember = true;

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) {
                return Page();//当前页面没有重定向，就不会走到OnGet()
                              // return RedirectToPage();
            }
            Entities.User user = userRepository.GetByName(Name);
            if (user == null) {
                ModelState.AddModelError(nameof(Name), "用户名不存在");
                //然而，当Model验证失败时，重定向会丢失ModelState的Error信息，导致验证错误信息无法显示。
                //1. 从ModelState中提取Error信息
                Dictionary<string, string> errors =
                    ModelState.Where(m => m.Value.Errors.Any())
                        .ToDictionary(
                            m => m.Key,
                            m => m.Value.Errors
                                .Select(s => s.ErrorMessage)
                                .FirstOrDefault(s => s != null));
                //2. 将Error信息存放到TempData
                TempData[Keys.ErrorInfo] = errors;//我们只能采取一些变通方式。其核心就是TempData中不直接存放ModelState，而是从ModelState中“抽取”出来的错误信息。

                //TempData["errorinPost"] = ModelState;//不行。新版的ASP.NET不允许直接将ModelState存储到TempData

                //errorinPost = ModelState;//---将OnPost()中的ModelState信息传递给OnGet()？用PageModel的变量行不通，http无状态
                // return Page();//解决方案一：1、当前页面，没有重定向，就不会走到OnGet()
                return RedirectToPage();//2、解决方案二、重定向，ModelState的error 传递到 OnGet

            }
            if (user.Password != Password) {
                ModelState.AddModelError(nameof(Password), "您的密码不正确");

                return Page();//当前页面
                              // return RedirectToPage();

            }

            CookieOptions options = new CookieOptions();

            if (Remember) {
                options.Expires = DateTime.Now.AddDays(3);
            }
            //else nothing // Expires after session
            Response.Cookies.Append(Keys.UserId, user.Id.ToString(), options
                            //, new Microsoft.AspNetCore.Http.CookieOptions() {
                            //    Expires = DateTime.Now.AddDays(14)
                            //}
                            );


            ViewData["HasLogOn"] = true;

            // userRepository.Save(user);

            return RedirectToPage("/index");//登录成功跳转到主页





        }
    }
}
