using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class KeywordRepository
    {
        string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YQBang4; Integrated Security = True;";

        private static IList<Keyword> keywords;
        static KeywordRepository()
        {
            keywords = new List<Keyword> {
                new Keyword {
                    Id=1,
                 Name="C#",

                },
                  new Keyword {
                    Id=2,
                 Name="Java",

                },
                    new Keyword {
                    Id=3,
                 Name="Php",

                },
                      new Keyword {
                    Id=4,
                 Name="UI",

                },
                        new Keyword {
                    Id=5,
                 Name="HTML",

                },
                          new Keyword {
                    Id=6,
                 Name="PS",

                },
                            new Keyword {
                    Id=7,
                 Name="CSS",

                },
                              new Keyword {
                    Id=8,
                 Name=".NET",

                },
            };

        }

        public Keyword Find(int id)
        {
            Keyword keyword = new Keyword();
            using (IDbConnection connection = new SqlConnection(connectionString)) {

                connection.Open();
                using (IDbCommand command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = $"SELECT [Id],[Name] FROM Keywords WHERE Id = {id}";
                    IDataReader reader = command.ExecuteReader();
                    if (reader.Read()) {

                        keyword.Id = Convert.ToInt32(reader["Id"]);
                        keyword.Name = reader["Name"].ToString();

                    }
                    else {
                        keyword = null;
                    }

                }


            }
            return keyword;

        }

        public List<Keyword> FindArticle(int ArticleId)
        {
            List<Keyword> keywords = new List<Keyword>();

            using (IDbConnection connection = new SqlConnection(connectionString)) {

                connection.Open();

                using (IDbCommand command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = $"SELECT [ArticleId],[KeywordId] FROM ArticletoKeyword WHERE ArticleId = @ArticleId ";
                    IDataParameter pArticleId = new SqlParameter("@ArticleId", ArticleId);
                    command.Parameters.Add(pArticleId);

                    //DBHelper helper = new DBHelper();
                    //string cmd = $"SELECT [ArticleId],[KeywordId] FROM ArticletoKeyword WHERE ArticleId = @ArticleId ";
                    //IDataParameter pArticleId = new SqlParameter("@ArticleId", ArticleId);
                    ////command.Parameters.Add(pArticleId);

                    //IDataReader reader = helper.ExecuteScalar(cmd,pArticleId);


                    IDataReader reader = command.ExecuteReader();
                    while (reader.Read()) {

                        keywords.Add(Find(Convert.ToInt32(reader["KeywordId"])));
                    }





                    return keywords;

                }



                // return keywords;
            }




        }
    }
    }

