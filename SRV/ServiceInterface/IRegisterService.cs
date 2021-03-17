using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterface
{
    public interface IRegisterService
    {
        int  Register(RegisterModel model);
        string GetPwdById(int currentUserId);
        RegisterModel GetByName(string name);
    }
}
