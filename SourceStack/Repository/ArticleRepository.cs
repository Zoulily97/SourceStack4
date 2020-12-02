using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class ArticleRepository
    {
        private static IList<Article> Articles;
        public int ArticleCount { get; set; } = Articles.Count;
        static ArticleRepository()
        {
            Articles = new List<Article>
            {
                new Article()
                {
                    Id=1,
                    Title="1《高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程》",
                     Body = "泛型可以有泛型方法/类等，同C#可以有约束public class Student<T extends IMajor> extends Person {子类继承时：public class OnlineStudent<T extends IMajor> extends Student<T > {协变/逆变通配符：？实现extends：协变（out）super：逆变（in）Optional 类对应NullableOptional<Integer> age = …",
                      Author=new User()
                    {
                        Id=1,
                        Name="大啥"

                    },
                      keywords=new List<Keyword>(){
                       new Keyword {
                    Id=1,
                 Name="C#",

                },
                  new Keyword {
                    Id=2,
                 Name="Java",

                },
                    new Keyword {
                    Id=1,
                 Name="Php",

                },}


                },
                 new Article()
                {
                    Id=2,
                    Title="2《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    },
                       keywords=new List<Keyword>(){
                       new Keyword {
                    Id=1,
                 Name="C#",

                },
                  new Keyword {
                    Id=2,
                 Name="Java",

                },
                    new Keyword {
                    Id=1,
                 Name="Php",

                },}

                },
                  new Article()
                {
                    Id=3,
                    Title="3《ASP.NET：SEO：JavaScript/静态URL/链接权重》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }
                      , keywords=new List<Keyword>(){
                       new Keyword {
                    Id=1,
                 Name="C#",

                },
                  new Keyword {
                    Id=2,
                 Name="Java",

                },
                    new Keyword {
                    Id=1,
                 Name="Php",

                },}

                },
                    new Article()
                {
                    Id=4,
                    Title="4《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                      new Article()
                {
                    Id=5,
                    Title="5《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }
                },
                        new Article()
                {
                    Id=6,
                    Title="6《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                          new Article()
                {
                    Id=7,
                    Title="7《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                           new Article()
                {
                    Id=8,
                    Title="8《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                            new Article()
                {
                    Id=9,
                    Title="9《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                             new Article()
                {
                    Id=10,
                    Title="10《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                              new Article()
                {
                    Id=11,
                    Title="11《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                               new Article()
                {
                    Id=12,
                    Title="12《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                                new Article()
                {
                    Id=13,
                    Title="13《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                                 new Article()
                {
                    Id=14,
                    Title="14《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                                  new Article()
                {
                    Id=15,
                    Title="15《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },
                                   new Article()
                {
                    Id=16,
                    Title="16《异步方法和TPL： async / await / Parallel》",
                     Body = "封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？（提示：不要",
                      Author=new User()
                    {
                        Id=2,
                        Name="大睡"

                    }

                },


            };
        }

        internal IList<Article> Get(int pageIndex, int pageSize)
        {
            return Articles.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public Article Find(int id)
        {
            //    Article Article = new Article()
            //    {
            //        Title = "田田",
            //        Body = "hgcbsjhfcoevffdovhdfrv",
            //        Id = 9
            //};
            return Articles.Where(a => a.Id == id).SingleOrDefault();
            //return Article;
        }
        void Delete() { }
        void Save(Article Article)
        {
            Articles.Add(Article);
        }

    }
}
