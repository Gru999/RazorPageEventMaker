using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Interfaces {
    public interface IHotelRepository {
        List<Hotel> GetAllHotel();
        Hotel GetHotel(int id);
        void AddHotel(Hotel ho);
        void UpdateHotel(Hotel ho);
        void DeleteHotel(int id);
    }
}
