using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SourceStack.Pages.Profile
{
    public class WriteModel : PageModel
    {
        public string/*int*/ BirthMonth { get; set; }
        public IList<SelectListItem> AvailableMonths { get; } =
          new List<SelectListItem>
          {
                new SelectListItem("½ðÅ£×ù","4"),
                new SelectListItem{ Text="Ë«×Ó×ù", Value="5" },
                new SelectListItem{ Text="¾ÞÐ·×ù", Value="6", Selected=true },
          };
        public void OnGet()
        {
        }
    }
}
