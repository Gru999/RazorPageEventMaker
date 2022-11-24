using Microsoft.Extensions.Logging;
using RazorPageEventMaker.Helpers;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Services {
    public class JsonEventRepository : IEventRepository {
        string JsonFileName = @"C:\Users\Grubak\OneDrive\Documents\Datamatiker Martriale\Code\RazorPageEventMaker\RazorPageEventMaker\JsonData\JsonEvents.json";
        public void AddEvent(Event ev) {
            List<Event> @events = GetAllEvents().ToList();
            List<int> eventIds = new List<int>();
            foreach (var evt in events) {
                eventIds.Add(evt.Id);
            }
            if (eventIds.Count != 0) {
                int start = eventIds.Max();
                ev.Id = start + 1;
            } else {
                ev.Id = 1;
            }
            @events.Add(ev);
            JsonFileWriter.WritetoJson(@events, JsonFileName);
        }

        public void DeleteEvent(int id) {
            List<Event> events = GetAllEvents().ToList();               
            Event deleteEvent = GetEvent(id);
            events.Remove(deleteEvent);
            JsonFileWriter.WritetoJson(events, JsonFileName);
        }

        public List<Event> FilterEvent(string filter)
        {
            List<Event> filterList = new List<Event>();
            foreach (var ev in GetAllEvents())
            {
                if (ev.Name.Contains(filter) || ev.Description.Contains(filter) || ev.City.Contains(filter))
                {
                    filterList.Add(ev);
                }
            }
            return filterList;
        }

        public List<Event> GetAllEvents()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public Event GetEvent(int id) {
            List<Event> events = GetAllEvents();
            foreach (var v in events) {
                if (v.Id == id) {
                    return v;
                }
            }
            return new Event();
        }

        public void UpdateEvent(Event ev) {
            List<Event> events = GetAllEvents().ToList();
            if (@ev != null) {
                foreach (Event e in events) {
                    if (e.Id == ev.Id) {
                        e.Id = ev.Id;
                        e.Name = ev.Name;
                        e.City = ev.City;
                        e.Description = ev.Description;
                        e.DateTime = ev.DateTime;
                    }
                }
                JsonFileWriter.WritetoJson(events, JsonFileName);
            }
        }
    }
}
