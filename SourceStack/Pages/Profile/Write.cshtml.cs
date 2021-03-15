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
                new SelectListItem("��ţ��","4"),
                new SelectListItem{ Text="˫����", Value="5" },
                new SelectListItem{ Text="��з��", Value="6", Selected=true },
          };
        public void OnGet()
        {
        }
    }
}
