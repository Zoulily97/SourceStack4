﻿using SRV.ViewModel;
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
    }
}
