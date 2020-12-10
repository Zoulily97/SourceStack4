using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SourceStack.Entities;

namespace SourceStack.ViewComponents
{
    public class _Keywords:ViewComponent
    {
        public IViewComponentResult Invoke(int amount)
        {
            IList<Keyword> keywords = new List<Keyword> {
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
            };
            return View(keywords.Take(amount).ToList());
        }
    }
}
