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
        public KeywordRepository()
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
            };

        }

    }
}
