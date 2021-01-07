using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YQBangMVC.Models
{
    public class RegisterModel
    {

        [Display(Name = "用户名")]
        [Required(ErrorMessage = "用户名不能为空")]
        public string Name { get; set; }
        [Required(ErrorMessage = "性别不能为空")]
        public bool IsMale { get; set; }
        [Display(Name = "密码")]
        public string Password { get; set; }

        public string InviterNumber { set; get; }
        public string InviterName { get; set; }
    }
}