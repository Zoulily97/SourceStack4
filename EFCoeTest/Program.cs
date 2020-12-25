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
            //DBProblems();
            //IList<ProblemStatus> problemStatuses = new List<ProblemStatus> { ProblemStatus.assist, ProblemStatus.Rewarded };
            //GetBy(problemStatuses, true,true);
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
        static  void GetBy(IList<ProblemStatus> exclude, bool hasSummary, bool descByPublishTime)
        {
            SqlDbContext sqlDbContext = new SqlDbContext();
             sqlDbContext.Problems.Getexclude(exclude);
            sqlDbContext.Problems.GethasSummary();
            sqlDbContext.Problems.Desc(descByPublishTime);
            sqlDbContext.SaveChanges();
        }
    }
    
    public static class Extension
    {

        public static IQueryable <Problem > Getexclude(this IQueryable<Problem> problems, IList<ProblemStatus> exclude)
        {
            foreach (var item in exclude)
            {
                problems = problems.Where(p => p.Statu != item);
            }
            return problems;

        }
        public static  IQueryable<Problem> GethasSummary(this IQueryable<Problem> problems )
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
