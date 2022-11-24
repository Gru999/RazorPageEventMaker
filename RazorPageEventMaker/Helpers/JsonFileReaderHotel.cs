using RazorPageEventMaker.Models;
using System.Text.Json;

namespace RazorPageEventMaker.Helpers {
    public class JsonFileReaderHotel {
        public static List<Hotel> ReadJson(string JsonFileName) {
            using (var jsonFileReader = File.OpenText(JsonFileName)) {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Hotel>>(indata);
            }
        }
    }
}
