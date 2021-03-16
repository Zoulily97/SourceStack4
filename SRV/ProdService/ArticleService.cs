using AutoMapper;
using BLL.Entities;
using BLL.Repositories;
using ServiceInterface;
using SRV.ViewModel.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ProdService
{
    public class ArticleService : IArticleService
    {
        private UserRepository userRepository;
        private ArticleRepository articleRepository;
        public ArticleService()
        {
            SqlDbcontext context = new SqlDbcontext();
            articleRepository = new ArticleRepository(context);
            userRepository = new UserRepository(context);
        }
        public SingleModel GetById(int id)
        {
            Article article = articleRepository.GetById(id);

            //1、得到一个MapperConfiguration（映射配置）实例
            MapperConfiguration config =
                new MapperConfiguration(cfg => cfg.CreateMap<Article, SingleModel>());
            //2、根据MapperConfiguration得到一个IMapper对象

            IMapper mapper = config.CreateMapper();
            //3、调用IMapper的Map()方法开始映射
            SingleModel model = mapper.Map<SingleModel>(article);
            return model;

            //return new SingleModel
            //{
            //    Title = article.Title,
            //    Body = article.Body
            //};
        }

        public int Publish(NewModel model, int? currentUserId)
        {
            Article a1 = new Article
            {
                Title = model.Title,
                Body = model.Body,
                // PublishTime=model.PublishTime
                 

            };
            User author = userRepository.LoadProxy(currentUserId);
            a1.Author = author;//给文章加一个author
            //articleRepository.context.Set<User>().Attach(author);//暴露了context
            articleRepository.Save(a1);
            return  a1.Id;
        }

       

        
    }
}
