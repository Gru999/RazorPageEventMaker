using RazorPageEventMaker.Helpers;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Services
{
    public class JsonHotelRepository : IHotelRepository {
        string JsonFileName = @"C:\Users\Grubak\OneDrive\Documents\Datamatiker Martriale\Code\RazorPageEventMaker\RazorPageEventMaker\JsonData\JsonHotels.json";
        public void AddHotel(Hotel ho) {
            List<Hotel> hotels = GetAllHotel().ToList();
            List<int> hotelIds = new List<int>();
            foreach (var htl in hotels) {
                hotelIds.Add(htl.Id);
            }
            if (hotelIds.Count != 0) {
                int start = hotelIds.Max();
                ho.Id = start + 1;
            } else {
                ho.Id = 1;
            }
            hotels.Add(ho);
            JsonFileWriter.WritetoJsonHotels(hotels, JsonFileName);
        }

        public List<Hotel> GetAllHotel() {
            return JsonFileReader.ReadJsonHotels(JsonFileName);
        }

        public Hotel GetHotel(int id) {
            List<Hotel> hotels = GetAllHotel();
            foreach (var h in hotels) {
                if (h.Id == id) {
                    return h;
                }
            }
            return new Hotel();
        }

        public void UpdateHotel(Hotel ho) {
            List<Hotel> hotels = GetAllHotel().ToList();
            if (ho != null) {
                foreach (Hotel h in hotels) {
                    if (h.Id == ho.Id) {
                        h.Id = ho.Id;
                        h.Name = ho.Name;
                        h.Address = ho.Address;
                    }
                }
                JsonFileWriter.WritetoJsonHotels(hotels, JsonFileName);
            }
        }

        public void DeleteHotel(int id) {
            List<Hotel> hotels = GetAllHotel().ToList();
            Hotel deleteHotel = GetHotel(id);
            hotels.Remove(deleteHotel);
            JsonFileWriter.WritetoJsonHotels(hotels, JsonFileName);

        }
    }
}
