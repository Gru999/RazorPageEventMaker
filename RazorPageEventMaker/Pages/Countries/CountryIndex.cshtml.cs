using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Countries
{
    public class CountryIndexModel : PageModel
    {
        private ICountryRepository _repo;
        public List<Country> Countries { get; private set; }
        public CountryIndexModel(ICountryRepository repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
            Countries = _repo.GetAllCountries();
        }
    }
}
