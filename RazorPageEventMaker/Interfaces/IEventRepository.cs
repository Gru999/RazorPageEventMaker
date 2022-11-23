using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Interfaces
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        void AddEvent(Event ev);
        void UpdateEvent(Event ev);
    }
}
