using System.Collections.Concurrent;
using EventEase.Shared.Models;

namespace EventEase.Client.Services
{
    public class UserSessionService
    {
        private readonly ConcurrentBag<RegistrationModel> _registrations = new();
        public void AddRegistration(RegistrationModel reg) => _registrations.Add(reg);
        public IEnumerable<RegistrationModel> GetRegistrations(int? eventId = null)
        {
            var list = _registrations.ToList();
            if (eventId.HasValue) return list.Where(r => r.EventId == eventId.Value);
            return list;
        }
    }
}
