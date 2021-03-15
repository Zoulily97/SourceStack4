using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SourceStack.Entities;
using SourceStack.Repository;

namespace SourceStack.ViewComponents
{
    public class _Keywords:ViewComponent
    {
        private KeywordRepository keywordRepository;
        public _Keywords()
        {
            keywordRepository = new KeywordRepository();
        }
        public IViewComponentResult Invoke(int amount)
        {
            IList<Keyword> keywords = keywordRepository.Get();
            return View(keywords.Take(amount).ToList());
        }
    }
}
