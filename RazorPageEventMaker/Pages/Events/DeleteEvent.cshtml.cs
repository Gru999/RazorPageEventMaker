using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Events {
    public class DeleteEventModel : PageModel {
        private IEventRepository _repo;
        [BindProperty]
        public Event Event { get; set; }
        public DeleteEventModel(IEventRepository fakeEventRepository)
        {
            _repo = fakeEventRepository;
        }
        public void OnGet(int id) {
            Event = _repo.GetEvent(id);
        }

        public IActionResult OnPost() {
            _repo.DeleteEvent(Event.Id);
            return RedirectToPage("Index");
        }
    }
}
