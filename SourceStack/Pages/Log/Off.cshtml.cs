using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Log
{

    public class OffModel : PageModel
    {
        //public void OnGet()
        //{
        //   // Response.Cookies.Delete(Keys.UserId);
        //}
        public IActionResult OnGet()
        {
            Response.Cookies.Delete(Keys.UserId);
            // return Page();
            //return RedirectToPage("/Log/On");//302//重定向：RedirectToPage()
            //  return RedirectToPagePermanent("/Article/Single");//301暂时
            // return Redirect("https://www.baidu.com/");
            return Redirect(Request.Headers["referer"]);
            //退出到当前页面//LogOff之后应该是“刷新”当前页面，根据HTTP协议，
            //每一次请求，都要记住该请求源自哪个页面，该信息记录在Request的请求头referer项下
        }
    }
}
