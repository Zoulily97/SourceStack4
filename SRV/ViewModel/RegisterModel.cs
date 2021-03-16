using System.ComponentModel.DataAnnotations;

namespace SRV.ViewModel
{
    public class RegisterModel
    {

        [Display(Name = "用户名")]
        [Required(ErrorMessage = "用户名不能为空")]
        public string Name { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        [Display(Name = "密码")]
        public string Password { get; set; }
        [Required(ErrorMessage = "确认密码不能为空")]
        [Display(Name = "确认密码")]
        public string ComfirmPassword { get; set; }
        public string InviterNumber { set; get; }//邀请码
        public string InviterName { get; set; }//邀请人
    }
}