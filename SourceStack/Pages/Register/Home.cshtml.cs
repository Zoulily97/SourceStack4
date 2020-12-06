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

        [StringLength(4,ErrorMessage ="4λ�ַ�")]
        [Required(ErrorMessage = "������ ����Ϊ��")]
        public string InviteCode { get; set; }

        public string VerifyCode { get; set; }

        [Url(ErrorMessage ="��ַ�����ʽ����ȷ")]
        public string HomeUrl { get; set; }
        public void OnGet()
        {
           
        }
        public void OnPost()
        {

          
            E.User invitedBy = userRepository.GetByName(NewUser.Inviter.Name);
            //�Զ�����֤
            if (invitedBy==null) {
                ModelState.AddModelError("NewUser.Inviter.Name", "�����˲���Ϊ��");
                return;
            }
            if (InviteCode != invitedBy.InviterNumber) {
                ModelState.AddModelError("InviteCode", "�����벻��");
                return;
            }
            if (ComfirmPassword!=NewUser.Password) {
                ModelState.AddModelError("ComfirmPassword", "�����������벻һ��");
                return;
            }

            //if (!ModelState.IsValid) {

            //    return;
            //}
            //ModelState.AddModelError("", "ȫ������");

            NewUser.Register();
            userRepository.Save(NewUser);
        }
    }
}
