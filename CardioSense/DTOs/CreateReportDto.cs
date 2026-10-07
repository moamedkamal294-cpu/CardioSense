namespace CardioSense.DTOs
{
    public class CreateReportDto
    {
        public int DoctorId { get; set; }
        public int EcgRecordId { get; set; }
        public string Diagnosis { get; set; } = string.Empty;
    }
}