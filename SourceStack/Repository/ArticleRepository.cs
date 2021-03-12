using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class ArticleRepository
    {


        
        private static IList<Article> articles;
        //  public int ArticleCount { get; set; } = Articles.Count;
        static ArticleRepository()
        {
            //KeywordRepository keywordRepository = new KeywordRepository();
            //articles = new List<Article>();

            //string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            //using (IDbConnection connection = new SqlConnection(connectionString)) {
            //    connection.Open();
            //    IDbCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandText = $"select * from Article";
            //    DbDataReader reader = (DbDataReader)command.ExecuteReader();
            //    if (reader.HasRows) {
            //        while (reader.Read()) {
            //            Article article = new Article {
            //                Author.Name = (string)reader["Name"],
            //                Body = (string)reader["Body"],
            //                Id = (int)reader["ID"],
            //                PublishTime = (DataSetDateTime)reader["datetime"],
            //                Title = (string)reader["Title"],
            //            };
            //            int articleId = article.Id;




            //            article.keywords = new List<Keyword>() {
            //                //  keywordRepository.FindArticle(articleId)
            //            };

            //            articles.Add(article);


            //        }
            //    }
            //}







            //   UserRepository userRepository = new UserRepository();
            //KeywordRepository keywordRepository = new KeywordRepository();
            //CommentRepository commentRepository = new CommentRepository();
            //Articles = new List<Article>
            //{
            //          new Article()
            //    {
            //         Id=1,
            //         Title="1《高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程》",
            //         Body = "泛型可以有泛型方法/类等，同C#可以有约束public class Student<T extends IMajor> extends Person {子类继承时：public class OnlineStudent<T extends IMajor> extends Student<T > {协变/逆变通配符：？实现extends：协变（out）super：逆变（in）Optional 类对应NullableOptional<Integer> age = …",
            //         Author=userRepository.Find(2),
            //          keywords=new List<Keyword>()
            //          {
            //           keywordRepository.Find(1),
            //           keywordRepository.Find(2),
            //           keywordRepository.Find(3),
            //              },
            //          Comments=new List<Comment> {
            //              commentRepository.Find(1),
            //               commentRepository.Find(4),
            //                commentRepository.Find(5),

            //          }



            //    },
            //         

            //    },


            //};





        }
        public int ArticleCount()
        {
            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            using (IDbConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select count(*) from Article";
                return (int)command.ExecuteScalar();
            }
        }
        internal IList<Article> Get(int pageIndex, int pageSize)
        {
            articles = new List<Article>();

            //DBHelper helper = new DBHelper();
            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            using (IDbConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select * from Article";
                DbDataReader reader = (DbDataReader)command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        Article article = new Article {
                            //  Author.Name = (string)reader["Name"],
                            Body = (string)reader["Body"],
                            Id = (int)reader["ID"],
                            //  PublishTime = (DataSetDateTime) reader["datetime"],
                            Title = (string)reader["Title"],
                        };
                        articles.Add(article);
                    }                   
                }
             
            } 
            return articles.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public Article Find(int id)
        {
            articles = new List<Article>();
            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";
            using (IDbConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select * from Article";
                DbDataReader reader = (DbDataReader)command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        Article article = new Article {
                            //  Author.Name = (string)reader["Name"],
                            Body = (string)reader["Body"],
                            Id = (int)reader["ID"],
                            //  PublishTime = (DataSetDateTime) reader["datetime"],
                            Title = (string)reader["Title"],
                        };
                        articles.Add(article);
                    }
                }

            }
            return articles.Where(a => a.Id == id).SingleOrDefault();

        }
        void Delete() { }
        void Save(Article Article)
        {
            articles.Add(Article);
        }

    }
}
