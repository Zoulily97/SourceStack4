using SRV.ViewModel;
using SRV.ViewModel.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterface
{
    public interface IUserService
    {
        int  Register(RegisterModel model);
        string GetPwdById(int currentUserId);
        UserModel GetByName(string name);
        int Publish(NewModel model/*, int? currentUserId*/);
    }
}
