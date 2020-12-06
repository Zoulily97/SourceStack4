using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class KeywordRepository
    {
        private static IList<Keyword> keywords;
        static  KeywordRepository()
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

        internal Keyword Find(int id)
        {
            return keywords.Where(a => a.Id == id).SingleOrDefault();
        }
    }
}
