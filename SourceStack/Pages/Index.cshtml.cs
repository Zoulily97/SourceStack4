using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SourceStack.Entities;
using SourceStack.Repository;

namespace SourceStack.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string Name { get; set; }

      

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(Request.Cookies[Keys.UserId])) {
                ViewData["HasLogOn"] = true;
            }

        }
        public void OnPost()
        {

        }
    }
}
