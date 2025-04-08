namespace WellBeing.Services.UserHealthAPI.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }

        public int HospitalName { get; set; }

        public int Address { get; set; }

        public string City { get; set; }

        public float State { get; set; }

        public int Zipcode { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string ContactNumber { get; set; }

        public string ServicesAvailable { get; set; }


    }
}
