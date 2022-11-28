using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Countries
{
    public class CreateCountryModel : PageModel
    {
        private ICountryRepository _repo;
        [BindProperty]
        public Country Country { get; set; }
        public CreateCountryModel(ICountryRepository repo)
        {
            _repo = repo;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.AddCountry(Country);
            return RedirectToPage("CountryIndex");
        }
    }
}
