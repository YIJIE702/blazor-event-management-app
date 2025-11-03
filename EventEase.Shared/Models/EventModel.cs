using System;

namespace EventEase.Shared.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
