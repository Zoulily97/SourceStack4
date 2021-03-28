using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSHomeWork.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        [BindProperty]
        [FromBody]
        public Student Student  { get; set; }
        private readonly ILogger<IndexModel> _logger;
        public string Name { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(IndexModel model)
        {
            Student student = new Student();
            model.Name = student.Name;
        }

        public void OnPost()
        {
            

        }
    }
    public class Student
    {
        public string Name { get; set; }
    }
}
