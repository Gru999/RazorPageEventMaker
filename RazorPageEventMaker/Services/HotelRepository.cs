using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;
using Microsoft.Extensions.Logging;


namespace RazorPageEventMaker.Models
{
    public class HotelRepository : IHotelRepository
    {

        private List<Hotel> _hotels { get; }

        public HotelRepository()
        {
            _hotels = new List<Hotel>();
            Hotel h1 = new Hotel(1, "City Hotel", "Street 123");
            Hotel h2 = new Hotel(2, "Scandic Roskilde", "Maglegårdsvej 1");
            _hotels.Add(h1);
            _hotels.Add(h2);

        }
        public void AddHotel(Hotel ho)
        {
            List<int> hotelIds = new List<int>();
            foreach (var htl in _hotels)
            {
                hotelIds.Add(htl.Id);
            }
            if (hotelIds.Count != 0)
            {
                int start = hotelIds.Max();
                ho.Id = start + 1;
            }
            else
            {
                ho.Id = 1;
            }
            _hotels.Add(ho);
        }

        public List<Hotel> GetAllHotel()
        {
            return _hotels;
        }

        public Hotel GetHotel(int id)
        {
            foreach (var v in GetAllHotel())
            {
                if (v.Id == id)
                {
                    return v;
                }
            }
            return new Hotel();
        }

        public void UpdateHotel(Hotel ho)
        {
            if (ho != null)
            {
                foreach (var e in GetAllHotel())
                {
                    if (e.Id == ho.Id)
                    {
                        e.Id = ho.Id;
                        e.Name = ho.Name;
                        e.Address = ho.Address;

                    }
                }
            }
        }
    }
}
