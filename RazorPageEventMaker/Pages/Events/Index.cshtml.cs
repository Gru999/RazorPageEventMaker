using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Events {
    public class IndexModel : PageModel {
        private IEventRepository repo;
        public string FilterCriteria { get; set; }
        public List<Event> Events { get; private set; }
        public IndexModel(IEventRepository fakeEventRepository) { 
            repo = fakeEventRepository;
        }
        public void OnGet() {
            Events = repo.GetAllEvents();
        }
        public void OnPost() {
            if (FilterCriteria != null)
                Events = repo.FilterEvent(FilterCriteria);
            else
                Events = repo.GetAllEvents();
        }
    }
}
