using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Events {
    public class CreateEventModel : PageModel {
        private IEventRepository _repo;
        [BindProperty]
        public Event Event { get; set; }
        public CreateEventModel(IEventRepository fakeEventRepository)
        {
            _repo = fakeEventRepository;
        }
        public IActionResult OnGet() {
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            _repo.AddEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
