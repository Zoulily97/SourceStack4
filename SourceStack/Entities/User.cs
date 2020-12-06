using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.ModelValidations;

namespace SourceStack.Entities
{
    public class User : Content
    {
        [Display(Name = "用户名")]
        //  [DisplayFormat(ConvertEmptyStringToNull =false)]
        [Required(ErrorMessage = "用户名不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "性别不能为空")]
        public bool IsMale { get; set; }

        [Required(ErrorMessage = "密码不能为空")]
        //[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", 
        //ErrorMessage = "密码格式不正确，至少8个字符，至少1个大写字母，1个小写字母和1个数字,不能包含特殊字符（非数字字母）")]
        // [MinLength(4,ErrorMessage ="密码长度不能小于4")]
        [Password]
        [Display(Name="密码")]
        public string Password { get; set; }

        public string InviterNumber { set; get; }
        public User Inviter { get; set; }

        //public int HelpMoney { get; set; }
        public void Register()
        {
            Inviter.HelpMoney += 10;
        }

    }
}
