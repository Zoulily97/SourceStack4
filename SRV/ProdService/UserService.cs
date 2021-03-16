using AutoMapper;
using BLL.Entities;
using BLL.Repositories;
using Global;
using ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ProdService
{
    public class UserService : IUserService
    {
        private UserRepository userRepository;
        public UserService()
        {
            SqlDbcontext context = new SqlDbcontext();
            userRepository = new UserRepository(context);
        }

        public UserModel GetByName(string name)
        {
            User user= userRepository.GetByName(name);
            if (user == null)
            {
                return null;
            }
            else
            {
 return new UserModel
            {
                Name = user.Name,
                Password = user.Password
            };
            }
           

        }

        public string GetPwdById(int currentUserId)
        {
            return userRepository.LoadProxy(currentUserId).Password;
        }

        public int  Register(UserModel model)
        {
            
            User user = new User
            {
                Name = model.Name,
                Password = model.Password
                //Password = model.Password.MD5Crypt()
            };
            // user .Register();
            userRepository.Save(user);
            return user.Id;
        
        
        
        }

        public string MD5Crypt(string source)
        {
            byte[] bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(source));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString ("X"));

            }
            //return Encoding.UTF8.GetString(bytes);
            return sb.ToString();
        }
    }
}
