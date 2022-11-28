using RazorPageEventMaker.Models;
using System.Text.Json;

namespace RazorPageEventMaker.Helpers { 
    public class JsonFileReader {
        public static List<Event> ReadJson(string JsonFileName) {
            using (var jsonFileReader = File.OpenText(JsonFileName)) {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Event>>(indata);
            }
        }
        public static List<Hotel> ReadJsonHotels(string JsonFileName)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Hotel>>(indata);
            }
        }
        public static List<Country> ReadJsonCountries(string filePath)
        {
            using (var jsonFileReader = File.OpenText(filePath))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Country>>(indata);
            }
        }
    }
}
