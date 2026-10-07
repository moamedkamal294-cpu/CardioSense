namespace CardioSense.DTOs
{
    public class EcgUploadDto
    {
        public int StudentId { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }
}