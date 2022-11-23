using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Events {
    public class CreateEventModel : PageModel {
        private FakeEventRepository repo;
        [BindProperty]
        public Event Event { get; set; }
        public CreateEventModel() { 
            repo = FakeEventRepository.Instance;
        }
        public IActionResult OnGet() {
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            repo.AddEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
