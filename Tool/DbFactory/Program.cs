using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Helper.GetDbcontext().Database.Delete();
            Helper.GetDbcontext().Database.Create();
            UserFactory.Create();
           // ArticleFactory.Create();
            Console.WriteLine("ok");



        }
    }
}
