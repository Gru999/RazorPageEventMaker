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
    }
}
