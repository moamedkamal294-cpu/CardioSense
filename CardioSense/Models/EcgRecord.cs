namespace CardioSense.Models
{
    public class EcgRecord
    {
        public int RecordId { get; set; }
        public int StudentId { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public string AiResult { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; } = DateTime.UtcNow;
    }
}