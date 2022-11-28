using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Countries
{
    public class DeleteCountryModel : PageModel
    {
        private ICountryRepository _repo;
        [BindProperty]
        public Country Country { get; set; }
        public DeleteCountryModel(ICountryRepository repo)
        {
            _repo = repo;
        }
        public void OnGet(string code)
        {
            Country = _repo.GetCountry(code);
        }
        public IActionResult OnPost()
        {
            _repo.DeleteCountry(Country.Code);
            return RedirectToPage("CountryIndex");
        }
    }
}
