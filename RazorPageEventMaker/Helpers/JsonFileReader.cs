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
    }
}
