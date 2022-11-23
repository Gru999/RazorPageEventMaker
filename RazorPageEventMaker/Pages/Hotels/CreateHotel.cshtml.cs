using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Hotels
{
    public class CreateHotelModel : PageModel
    {
        private IHotelRepository repo;
        [BindProperty]
        public Hotel Hotel { get; set; }
        public CreateHotelModel(IHotelRepository hotelRepository)
        {
            repo = hotelRepository;
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
            repo.AddHotel(Hotel);
            return RedirectToPage("Index");
        }
    }
}
