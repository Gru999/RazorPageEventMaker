using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Countries
{
    public class CountryEventsModel : PageModel
    {
        private ICountryRepository _repo;
        public Country Country { get; set; }
        public List<Event> Events { get; set; }
        public CountryIndexModel(ICountryRepository conRepo) {
            _repo = conRepo;
        }
        public void OnGet(string code) {
            Country = _repo.GetCountry(code);
        }
    }
}
