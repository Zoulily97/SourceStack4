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
   // [IsShowLogOn]//  ҳ����ʾ��¼״̬
    public class OnModel : PageModel
    {
        private UserRepository userRepository;
         public OnModel()
        {
            userRepository = new UserRepository();
        }

        [Required(ErrorMessage = "���벻��Ϊ��")]
        [Display(Name = "����")]
      //  [Password]
        public string Password { get; set; }

        [Required(ErrorMessage = "�û�������Ϊ��")]
        public string Name { get; set; }

        public bool Remember { get; set; }
        private ModelStateDictionary errorinPost;//����һ������
        public void OnGet()
        {
            ////cookie��ȷ�ϵ�ǰ�û��ĵ�¼״̬��
            //if (!string.IsNullOrEmpty(Request.Cookies[Keys.UserId])) {
            //    ViewData["HasLogOn"] = true;
            //}

            //3. ��TempData��ȡ��Error��Ϣ
            Dictionary<string, string> errors = TempData[Keys.ErrorInfo] as Dictionary<string, string>;
            if (errors != null) {
                //4. ��Error��Ϣ��ӵ�ModelState 
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
                return Page();//��ǰҳ��û���ض��򣬾Ͳ����ߵ�OnGet()
                              // return RedirectToPage();
            }
            Entities.User user = userRepository.GetByName(Name);
            if (user == null) {
                ModelState.AddModelError(nameof(Name), "�û���������");
                //Ȼ������Model��֤ʧ��ʱ���ض���ᶪʧModelState��Error��Ϣ��������֤������Ϣ�޷���ʾ��
                //1. ��ModelState����ȡError��Ϣ
                Dictionary<string, string> errors =
                    ModelState.Where(m => m.Value.Errors.Any())
                        .ToDictionary(
                            m => m.Key,
                            m => m.Value.Errors
                                .Select(s => s.ErrorMessage)
                                .FirstOrDefault(s => s != null));
                //2. ��Error��Ϣ��ŵ�TempData
                TempData[Keys.ErrorInfo] = errors;//����ֻ�ܲ�ȡһЩ��ͨ��ʽ������ľ���TempData�в�ֱ�Ӵ��ModelState�����Ǵ�ModelState�С���ȡ�������Ĵ�����Ϣ��

                //TempData["errorinPost"] = ModelState;//���С��°��ASP.NET������ֱ�ӽ�ModelState�洢��TempData

                //errorinPost = ModelState;//---��OnPost()�е�ModelState��Ϣ���ݸ�OnGet()����PageModel�ı����в�ͨ��http��״̬
                // return Page();//�������һ��1����ǰҳ�棬û���ض��򣬾Ͳ����ߵ�OnGet()
                return RedirectToPage();//2��������������ض���ModelState��error ���ݵ� OnGet

            }
            if (user.Password != Password) {
                ModelState.AddModelError(nameof(Password), "�������벻��ȷ");

                return Page();//��ǰҳ��
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

            return RedirectToPage("/index");//��¼�ɹ���ת����ҳ





        }
    }
}
