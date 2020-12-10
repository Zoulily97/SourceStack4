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
   // [ModelValidation]
   // [IsShowLogOn]//  ҳ����ʾ��¼״̬
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
        public IActionResult OnPost()
        {

            E.User invitedBy = userRepository.GetByName(NewUser.Inviter.Name);

            //�Զ�����֤
            if (invitedBy == null) {
                ModelState.AddModelError("NewUser.Inviter.Name", "�����˲���Ϊ��");
                return Page();
            }
            if (InviteCode != invitedBy.InviterNumber) {
                ModelState.AddModelError("InviteCode", "�����벻��");
                return Page();
            }
            if (ComfirmPassword != NewUser.Password) {
                ModelState.AddModelError("ComfirmPassword", "�����������벻һ��");
                return Page();
            }

            //if (!ModelState.IsValid) {

            //    return Page();
            //}
            //ModelState.AddModelError("", "ȫ������");
            NewUser.Register();
            userRepository.Save(NewUser);
            return RedirectToPage("/index");//��¼�ɹ���ת����ҳ
        }
    }
}
