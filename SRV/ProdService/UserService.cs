using AutoMapper;
using BLL.Entities;
using BLL.Repositories;
using Global;
using ServiceInterface;
using SRV.ViewModel;
using SRV.ViewModel.Article;
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
        private ArticleRepository articleRepository;
        public KeywordRepository keywordRepository;
        public UserService()
        {
            SqlDbcontext context = new SqlDbcontext();
            userRepository = new UserRepository(context);
            articleRepository = new ArticleRepository(context);
            keywordRepository = new KeywordRepository(context);
        }

        public UserModel GetByName(string name)
        {
            User user = userRepository.GetByName(name);
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

        public int Register(RegisterModel model)
        {

            User user = new User
            {
                Name = model.Name,
                Password = model.Password,
                InvitedBy = new User().InvitedBy
            

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
                sb.Append(bytes[i].ToString("X"));

            }
            //return Encoding.UTF8.GetString(bytes);
            return sb.ToString();
        }
        public int Publish(NewModel model/*, int? currentUserId*/)
        {

            //Article a1 = new Article();
            //1、得到一个MapperConfiguration（映射配置）实例
            MapperConfiguration config =
                new MapperConfiguration(cfg => cfg.CreateMap<NewModel, Article>());
            //2、根据MapperConfiguration得到一个IMapper对象

            IMapper mapper = config.CreateMapper();
            //3、调用IMapper的Map()方法开始映射
            Article a1 = mapper.Map<Article>(model);

            //Article a1 = new Article
            //{
            //    Title = model.Title,
            //    Body = model.Body,
            //   // Keywords=model.KeyWord,
            //    Summary=model.Summary,




            //};

            int currentUserId = 1;
            User author = userRepository.LoadProxy(currentUserId);
            a1.Author = author;//给文章加一个author
            //articleRepository.context.Set<User>().Attach(author);//暴露了context
            articleRepository.Save(a1);
            if (a1.Keywords != null)
            {
                foreach (var item in a1.Keywords)
                {
                    keywordRepository.Save(item);

                }
            }


            return a1.Id;
        }

    }
}
