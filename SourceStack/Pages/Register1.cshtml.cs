using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SourceStack.Repository;
using E = SourceStack.Entities;

namespace SourceStack.Pages
{
    public class Register1Model : PageModel
    { 
        
        public E.User NewUser { get; set; }
        public bool RememberMe { get; set; }
        public int RegisterId { get; set; }
        public string BirthMonth { get; set; }
       
        public IEnumerable<SelectListItem> AvaiableMonth { get; set; }

        public void OnGet()
        {
            AvaiableMonth = new SelectList(new ArticleRepository().Get(1, 5),"Id",nameof(Entities.Article.Title));
        }
        public void Post()
        {
            Page();
        }
    }
}
