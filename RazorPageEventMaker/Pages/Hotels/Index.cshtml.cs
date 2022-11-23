using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Pages.Hotels {
    public class IndexModel : PageModel {
        private IHotelRepository repo;
        public List<Hotel> Hotels { get; set; }
        public IndexModel(IHotelRepository hotelRepository) {
            repo = hotelRepository;
        }
        public void OnGet() {
            Hotels = repo.GetAllHotel();
        }
    }
}
