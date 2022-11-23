using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Hotels
{
    public class EditHotelModel : PageModel
    {
        private IHotelRepository repo;
        [BindProperty]
        public Hotel Hotel { get; set; }
        public EditHotelModel(IHotelRepository hotelRepository)
        {
            repo = hotelRepository;
        }
        public IActionResult OnGet(int id)
        {
            Hotel = repo.GetHotel(id);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.UpdateHotel(Hotel);
            return RedirectToPage("Index");
        }
    }
}
