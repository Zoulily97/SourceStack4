using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStack.ModelValidations
{
    //自定义验证
    public class PasswordAttribute : RegularExpressionAttribute 
    {
        public PasswordAttribute(/*string pattern*/) : base(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")
        {

        }
        public override string FormatErrorMessage(string name)
        {
            return $"{name}的格式不正确，至少8个字符，至少1个大写字母，1个小写字母和1个数字,不能包含特殊字符（非数字字母)";
        }
    }
}
