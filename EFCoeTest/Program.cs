using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoeTest
{
    class Program
    {
        static void Main()
        {
            //DB();
            // DB1();
            IList<ProblemStatus> problemStatuses = new List<ProblemStatus> { ProblemStatus.assist, ProblemStatus.Rewarded };
            GetBy(problemStatuses, false, false);
            //Console.WriteLine(GetBy(problemStatuses, false, false).Count());//6
        }

        static void DBProblems()
        {
            SqlDbContext context = new SqlDbContext();
            Problem problem1 = new Problem
            {
                Statu = ProblemStatus.assist,
                Summary = "总结1",
                PublishTime = new DateTime(2019, 6, 1),
            };
            Problem problem2 = new Problem
            {
                Statu = ProblemStatus.cancelled,
                Summary = "总结2",
                PublishTime = new DateTime(2019, 7, 1),
            };
            Problem problem3 = new Problem
            {
                Statu = ProblemStatus.assist,
                Summary = "总结3",
                PublishTime = new DateTime(2019, 8, 1),
            };
            Problem problem4 = new Problem
            {
                Statu = ProblemStatus.assist,
                Summary = "总结4",
                PublishTime = new DateTime(2019, 9, 1),
            };
            Problem problem5 = new Problem
            {
                Statu = ProblemStatus.inprocess,
                // Summary = "总结4",
                PublishTime = new DateTime(2019, 9, 3),
            };
            Problem problem6 = new Problem
            {
                Statu = ProblemStatus.inprocess,
                //  Summary = "总结4",
                PublishTime = new DateTime(2019, 9, 7),
            };

            context.AddRange(problem1, problem2, problem3, problem4, problem5, problem6
               );
            context.SaveChanges();
        }
        static void DB()
        {
            SqlDbContext context = new SqlDbContext();
            var db = context.Database;
            db.EnsureDeleted();
            db.EnsureCreated();
        }
        static void DB1()
        {
            SqlDbContext context = new SqlDbContext();
            User user1 = new User { Name = "zl", Password = "123", CreateTime = DateTime.Now };
            User user2 = new User { Name = "lw", Password = "123", CreateTime = DateTime.Now };
            User user3 = new User { Name = "lzb", Password = "123", CreateTime = DateTime.Now };
            Problem problem1 = new Problem
            {
                Statu = ProblemStatus.assist,
                Summary = "总结1",
                PublishTime = new DateTime(2019, 6, 1),
            };
            Problem problem2 = new Problem
            {
                Statu = ProblemStatus.cancelled,
                Summary = "总结2",
                PublishTime = new DateTime(2019, 7, 1),
            };
            Problem problem3 = new Problem
            {
                Statu = ProblemStatus.assist,
                Summary = "总结3",
                PublishTime = new DateTime(2019, 8, 1),
            };
            Problem problem4 = new Problem
            {
                Statu = ProblemStatus.assist,
                Summary = "总结4",
                PublishTime = new DateTime(2019, 9, 1),
            };
            Problem problem5 = new Problem
            {
                Statu = ProblemStatus.inprocess,
                // Summary = "总结4",
                PublishTime = new DateTime(2019, 9, 3),
            };
            Problem problem6 = new Problem
            {
                Statu = ProblemStatus.inprocess,
                //  Summary = "总结4",
                PublishTime = new DateTime(2019, 9, 7),
            };
            Keyword k1 = new Keyword { Name = "C#" };
            Keyword k2 = new Keyword { Name = "UI" };
            Keyword k3 = new Keyword { Name = "SQL" };
            Email email1 = new Email { EmailLocation = "1" };
            Email email2 = new Email { EmailLocation = "2" };
            Email email3 = new Email { EmailLocation = "3" };
            Comment c1 = new Comment { PublishTime = DateTime.Now };
            Comment c2 = new Comment { PublishTime = new DateTime(2019, 9, 3) };
            Comment c3 = new Comment { PublishTime = new DateTime(2019, 10, 3) };
            Article a1 = new Article { PublishTime = new DateTime(2019, 9, 3), Title = "文章1" };
            Article a2 = new Article { PublishTime = new DateTime(2020, 9, 3), Title = "文章2" };
            Article a3 = new Article { PublishTime = new DateTime(2019, 10, 3), Title = "文章3" };
            a1.Keywords = new List<Keyword> { k1, k2 };
            a2.Keywords = new List<Keyword> { k3 };
            user1.SendTo = email1;
            user2.SendTo = email2;
            user3.SendTo = email3;
            user1.Articles = new List<Article> { a1, a2 };
            user2.Articles = new List<Article> { a3 };

            c1.Author = user1;
            c2.Author = user2;
            c3.Author = user3;

            context.AddRange(c1, c2, c3);
            context.AddRange(problem1, problem2, problem3, problem4, problem5, problem6);



            context.SaveChanges();






        }
        static IQueryable<Problem> GetBy(IList<ProblemStatus> exclude, bool hasSummary, bool descByPublishTime)
        {
            SqlDbContext sqlDbContext = new SqlDbContext();
            sqlDbContext.Problems.Getexclude(exclude).ToList();
            sqlDbContext.Problems.GethasSummary().ToList();
            sqlDbContext.Problems.Desc(descByPublishTime).ToList();
            sqlDbContext.SaveChanges();
            return sqlDbContext.Problems;
        }
    }

    public static class Extension
    {

        public static IQueryable<Problem> Getexclude(this IQueryable<Problem> problems, IList<ProblemStatus> exclude)
        {
            foreach (var item in exclude)
            {
                problems = problems.Where(p => p.Statu != item);
            }
            return problems;

        }
        public static IQueryable<Problem> GethasSummary(this IQueryable<Problem> problems)
        {
            return problems.Where(p => p.Summary != null);
        }

        public static IQueryable<Problem> Desc(this IQueryable<Problem> problems, bool desc)
        {
            if (desc)
            {
                return problems.OrderBy(p => p.PublishTime);
            }
            else
            {
                return problems.OrderByDescending(p => p.PublishTime);
            }
        }

    }
}
