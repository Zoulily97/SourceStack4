using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Repository;
using E = SourceStack.Entities;

namespace SourceStack.Pages.Message
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        private MessageRepository messageRepository;
        public IndexModel()
        {
            messageRepository = new MessageRepository();
        }
        [BindProperty]
        public IList<E.Message> Messages { get; set; }

        public void OnGet()
        {
            Messages = messageRepository.GetMine();
        }
        public void OnPost()
        {
            foreach (var item in Messages) {

                if (item.Selected) {
                    messageRepository.Find(item.Id).Read();
                   // messageRepository.GetMine();
                }
            }
        }
    }
}
