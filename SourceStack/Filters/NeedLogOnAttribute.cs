using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Filters
{
    public class NeedLogOnAttribute : /*ResultFilterAttribute*/Attribute, IAuthorizationFilter//验证
    {
        //public override void OnResultExecuting(ResultExecutingContext context)
        //{
        //    base.OnResultExecuting(context);
        //}
        //public override void OnResultExecuted(ResultExecutedContext context)
        //{
        //    base.OnResultExecuted(context);
        //}
        public void OnAuthorization(AuthorizationFilterContext context)
        {
           
        }
    }


    
    public class ContextPerRequestAttribute : Attribute,IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {

          
            
            HttpContext httpContext = context.HttpContext;
            //登录才能访问，不然就是访问指定页面
            if (string.IsNullOrEmpty(httpContext.Request.Cookies[Keys.UserId])) {
                context.Result = new RedirectToPageResult("/Log/On");

            }

        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
           
        }
    }
    public class ClearContextAttribute : Attribute,IResultFilter//RazorPage
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
           
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            
        }
    }
    public class CloseConnectionAttribute : ResultFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            base.OnResultExecuted(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);
        }
        public override Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            return base.OnResultExecutionAsync(context, next);
        }
    }
   
}
