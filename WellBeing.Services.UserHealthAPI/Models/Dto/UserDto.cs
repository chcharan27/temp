﻿namespace WellBeing.Services.UserHealthAPI.Models.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        
        public string Gender { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string EmergencyContactName { get; set; }

        public string EmergencyContactNumber { get; set; }

        public DateTime DateTime { get; set; }


    }
}
