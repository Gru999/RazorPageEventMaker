using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Events
{
    public class EditEventModel : PageModel
    {
        private IEventRepository _repo;
        [BindProperty]
        public Event Event { get; set; }
        public EditEventModel(IEventRepository fakeEventRepository)
        {
            _repo = fakeEventRepository;
        }
        public IActionResult OnGet(int id)
        {
            Event = _repo.GetEvent(id);
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            _repo.UpdateEvent(Event);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostEdit()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.UpdateEvent(Event);
            return RedirectToPage("Index");

        }
        public IActionResult OnPostDelete(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.DeleteEvent(id);
            return RedirectToPage("Index");
        }
    }
}
