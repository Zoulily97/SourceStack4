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
            //return RedirectToPage("/Log/On");//302//�ض���RedirectToPage()
            //  return RedirectToPagePermanent("/Article/Single");//301��ʱ
            // return Redirect("https://www.baidu.com/");
            return Redirect(Request.Headers["referer"]);
            //�˳�����ǰҳ��//LogOff֮��Ӧ���ǡ�ˢ�¡���ǰҳ�棬����HTTPЭ�飬
            //ÿһ�����󣬶�Ҫ��ס������Դ���ĸ�ҳ�棬����Ϣ��¼��Request������ͷreferer����
        }
    }
}
