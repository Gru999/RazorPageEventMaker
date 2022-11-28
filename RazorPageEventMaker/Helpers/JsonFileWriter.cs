using RazorPageEventMaker.Models;
using System.Text.Json;

namespace RazorPageEventMaker.Helpers {
    public class JsonFileWriter {
        public static void WritetoJson(List<Event> events, string JsonFileName) {
            //using(FileStream outputStream =File.OpenWrite(JsonFileName))
            using (FileStream outputStream = File.Create(JsonFileName)) {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Event[]>(writter, events.ToArray());
            }
        }
        public static void WritetoJsonHotels(List<Hotel> hotels, string JsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(JsonFileName))
            using (FileStream outputStream = File.Create(JsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Hotel[]>(writter, hotels.ToArray());
            }
        }
        public static void WritetoJsonCountries(List<Country> countries, string filePath)
        {
            //using(FileStream outputStream =File.OpenWrite(JsonFileName))
            using (FileStream outputStream = File.Create(filePath))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Country[]>(writter, countries.ToArray());
            }
        }
    }
}
