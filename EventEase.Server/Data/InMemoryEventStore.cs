using EventEase.Shared.Models;
using System.Collections.Concurrent;

namespace EventEase.Server.Data
{
    // Simple thread-safe in-memory store for demo purposes
    public class InMemoryEventStore
    {
        private readonly List<EventModel> _events = new();
        private readonly ConcurrentBag<RegistrationModel> _registrations = new();

        public InMemoryEventStore()
        {
            // Seed sample events
            for (int i = 1; i <= 20; i++)
            {
                _events.Add(new EventModel
                {
                    Id = i,
                    Name = $"Event #{i}",
                    Date = DateTime.UtcNow.AddDays(i),
                    Location = $"Hall {((i % 5) + 1)}",
                    Description = "Sample event description."
                });
            }
        }

        public IEnumerable<EventModel> GetEvents() => _events;

        public EventModel? GetEvent(int id) => _events.FirstOrDefault(e => e.Id == id);

        public void AddRegistration(RegistrationModel reg) => _registrations.Add(reg);

        public IEnumerable<RegistrationModel> GetRegistrationsForEvent(int eventId) =>
            _registrations.Where(r => r.EventId == eventId);
    }
}
