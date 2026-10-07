namespace CardioSense.Models
{
    public class MedicalReport
    {
        public int ReportId { get; set; }
        public int DoctorId { get; set; }
        public int EcgRecordId { get; set; }
        public string Diagnosis { get; set; } = string.Empty;
        public DateTime ReportDate { get; set; } = DateTime.UtcNow;
    }
}