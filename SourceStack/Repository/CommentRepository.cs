using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class CommentRepository
    {
        private static IList<Comment> comments;
        static  CommentRepository()
        {

            //ArticleRepository articleRepository = new ArticleRepository();
            comments = new List<Comment> {
           new Comment {
               Id=1,
               //Article=articleRepository.Find(1),
               Content="讲得真的很不错哦！",
               Author=new User{Name="鱼儿"},
           },
           new Comment {
                 Id=2,
             //  Article=articleRepository.Find(2),
               Content="讲得真的很不错哦！",
                Author=new User{Name="鱼儿"},
           },
           new Comment {
                  Id=3,
            //   Article=articleRepository.Find(3),
               Content="讲得真的很不错哦！",
                Author=new User{Name="鱼儿"},
           },
           new Comment {
                   Id=4,
              // Article=articleRepository.Find(1),
               Content="讲得真的很不错哦！",
                Author=new User{Name="花儿"},

           },
           new Comment {
                     Id=5,
            //   Article=articleRepository.Find(1),
               Content="讲得真的很不错哦！",
                Author=new User{Name="米米儿"},
           },
           new Comment {
                     Id=6,
             //  Article=articleRepository.Find(2),
               Content="讲得真的很不错哦！",
                Author=new User{Name="鱼摆摆"},
           },



           };
                
            
        }

        internal Comment Find(int id)
        {
            return comments.Where(a => a.Id == id).SingleOrDefault();
        }
    }
}
