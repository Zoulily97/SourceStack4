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
    //对Model进行验证，在Model绑定之后，所以是IPageFilter
    public class ModelValidationAttribute : Attribute, IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {

        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            //1.Post 从ModelState中提取Error信息
          
            HttpContext httpContext = context.HttpContext;
            if (httpContext.Request.Method == "POST") {
                Dictionary<string, string> errors =
                     context.ModelState.Where(m => m.Value.Errors.Any())
                    .ToDictionary(
                        m => m.Key,
                        m => m.Value.Errors
                            .Select(s => s.ErrorMessage)
                            .FirstOrDefault(s => s != null));
                //2. Post 将Error信息存放到TempData
                ((PageModel)(context.HandlerInstance)).TempData[Keys.ErrorInfo] = errors;

                //有error重定向

                context.Result = new RedirectToPageResult("Log/on");
                if (httpContext.Request.Method == "Get") {
                    // 3.Get 从TempData里取出Error信息
                    Dictionary<string, string> errors1 = ((PageModel)(context.HandlerInstance)).TempData[Keys.ErrorInfo] as Dictionary<string, string>;
                    if (errors != null) {
                        //4. Get 将Error信息添加到ModelState 
                        foreach (var item in errors1) {
                            context.ModelState.AddModelError(item.Key, item.Value);
                        }
                    }
                    
                }



            }

         
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
           
        }
    }
}
