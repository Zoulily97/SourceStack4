using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E=SourceStack.Entities;
using SourceStack.Repository;
using System.ComponentModel.DataAnnotations;
using SourceStack.Filters;

namespace SourceStack.Pages.Register
{
    [BindProperties]
    [ModelValidation]
    public class HomeModel : PageModel
    {
        private UserRepository userRepository;
        public HomeModel()
        {
            userRepository = new UserRepository();
        }
        public E.User NewUser { get; set; }
        public bool RememberMe { get; set; }
        public int RegisterId { get; set; }
        public string ComfirmPassword { get; set; }

        [StringLength(4,ErrorMessage ="4位字符")]
        [Required(ErrorMessage = "邀请码 不能为空")]
        public string InviteCode { get; set; }

        public string VerifyCode { get; set; }

        [Url(ErrorMessage ="网址输入格式不正确")]
        public string HomeUrl { get; set; }
        public void OnGet()
        {
           
        }
        public void OnPost()
        {

          
            E.User invitedBy = userRepository.GetByName(NewUser.Inviter.Name);
            //自定义验证
            if (invitedBy==null) {
                ModelState.AddModelError("NewUser.Inviter.Name", "邀请人不能为空");
                return;
            }
            if (InviteCode != invitedBy.InviterNumber) {
                ModelState.AddModelError("InviteCode", "邀请码不对");
                return;
            }
            if (ComfirmPassword!=NewUser.Password) {
                ModelState.AddModelError("ComfirmPassword", "两次输入密码不一致");
                return;
            }

            //if (!ModelState.IsValid) {

            //    return;
            //}
            //ModelState.AddModelError("", "全都错了");

            NewUser.Register();
            userRepository.Save(NewUser);
        }
    }
}
