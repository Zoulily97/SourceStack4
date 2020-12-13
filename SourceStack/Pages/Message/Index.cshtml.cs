using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Filters;
using SourceStack.Repository;
using E = SourceStack.Entities;

namespace SourceStack.Pages.Message
{
    [IgnoreAntiforgeryToken]
    [ContextPerRequest]//需要登录才能访问
  //  [IsShowLogOn]//  页面显示登录状态
    public class IndexModel : PageModel
    {
        private MessageRepository messageRepository;
        public IndexModel()
        {
            messageRepository = new MessageRepository();
        }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty]
        public IList<E.Message> Messages { get; set; }


        //public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        //{
        //    base.OnPageHandlerSelected(context);
        //}
        //public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        //{

        //    //登录才能访问，不然就是访问指定页面
        //    if (string.IsNullOrEmpty(Request.Cookies[Keys.UserId])) {


        //        context.Result = new RedirectToPageResult("/Log/On");

        //    }
        //    base.OnPageHandlerExecuting(context);
        //}
        //public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        //{
        //    base.OnPageHandlerExecuted(context);
        //}
        //public override Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        //{
        //    return base.OnPageHandlerSelectionAsync(context);

        //}
        //public override Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        //{
        //    return base.OnPageHandlerExecutionAsync(context, next);
        //}

        public IActionResult OnGet()

        {
            //导航栏显示
            //if (!string.IsNullOrEmpty(Request.Cookies[Keys.UserId])) {
            //    ViewData["HasLogOn"] = true;
            //}

            Messages = messageRepository.GetMine(true);


            //登录才能访问，不然就是访问指定页面
            //if (string.IsNullOrEmpty (Request.Cookies[Keys.UserId])) {

            //    return RedirectToPage("/Log/On");

            //}
            return Page();
        }
        public RedirectToPageResult OnPost()
        {
            foreach (var item in Messages) {

                //被选择
                if (item.Selected) {
                    messageRepository.Find(item.Id).Read();
                    // messageRepository.GetMine();
                }
            }
            // Messages = messageRepository.GetMine(true);//未读的，当前页，就可以注释了
            //return RedirectToPage("/Article/Index", new { id=3});
            return RedirectToPage();//重定向当前页面，没有给参数   //PRG模式
        }
    }
}
