namespace EventEase.Shared.Models
{
    public class AttendanceModel
    {
        public int EventId { get; set; }
        public string UserEmail { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public bool Present { get; set; }
    }
}
