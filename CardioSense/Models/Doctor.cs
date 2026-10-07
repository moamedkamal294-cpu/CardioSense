namespace CardioSense.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public string LicenseNum { get; set; } = string.Empty;
    }
}