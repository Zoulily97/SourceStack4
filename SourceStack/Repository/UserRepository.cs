using System.Collections.Generic;
using System.Linq;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class UserRepository
    {
        public static IList<User> users;
        static UserRepository()
        {

            users = new List<User> {
                new User {
                    Id=1,
                    Name="小鱼",
                    //Inviter=new User{Name="yefei",InviterNumber="1234"},
                    InviterNumber="1234",
                    IsMale=false,
                    Password="Zou123456"

                },
                 new User {
                    Id=2,
                    Name="飞哥",
                    IsMale=true,
                     InviterNumber="1786",
                      Password="Dfg123456"
                    //Inviter=new User{Name="DK",InviterNumber="1234"},

                },
                   new User {
                    Id=3,
                    Name="阿瑞",
                     InviterNumber="1997",
                    IsMale=true,

                },
            };


        }

        public User Find(int id)
        {
            //    Article Article = new Article()
            //    {
            //        Title = "田田",
            //        Body = "hgcbsjhfcoevffdovhdfrv",
            //        Id = 9
            //};
            return users.Where(a => a.Id == id).SingleOrDefault();
            //return Article;
        }

        internal User GetByName(string name)
        {
            return users.Where(a => a.Name == name).SingleOrDefault();
        }

        public void Save(User user)
        {
            users.Add(user);
        }

    }
}



