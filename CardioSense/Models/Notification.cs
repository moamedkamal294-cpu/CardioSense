namespace CardioSense.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Unread / Read
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}