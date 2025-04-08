namespace WellBeing.Services.UserHealthAPI.Models
{
    public class HealthRecord
    {
        public int HealthRecordId { get; set; }

        public int UserId { get; set; }

        public int HeartRate { get; set; }

        public string BloodPressure { get; set; }

        public float BloodTemperature { get; set; }

        public int OxygenLevel { get; set; }

        public string StressLevel { get; set; }

        public string Mood { get; set; }

        public string MedicalCondition { get; set; }

        public string Medication { get; set; }

        public DateTime CeatedAt { get; set; }
    }
}
