using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class UserFactory
    {
        internal static User zs, ls, ws;
        static internal void Create()
        {
            zs = Register("zs");
            ls = Register("ls");
            ws = Register("ws");

        }
        private static User Register(string name)
        {
            const string pwd = "1234";
            User user = new User { Name = name, Password = pwd };
            // user.Register();
            UserRepository userRepository = new UserRepository(Helper.GetDbcontext());
            userRepository.Save(user);
            return user;
        }
    }
}
