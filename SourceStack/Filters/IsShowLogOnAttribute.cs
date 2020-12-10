using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Filters
{
    public class IsShowLogOnAttribute : Attribute, IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {

        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            HttpContext httpContext = context.HttpContext;
            //页面显示登录状态
            if (!string.IsNullOrEmpty(httpContext.Request.Cookies[Keys.UserId])) {
                ((PageModel)(context.HandlerInstance)).ViewData["HasLogOn"] = true;
            }
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {

        }
    }
}
