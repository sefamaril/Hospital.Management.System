﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class HospitalInfo : Base
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string Country { get; set; }
        [NotMapped]
        public ICollection<Room> Rooms { get; set; }
        [NotMapped]
        public ICollection<Contact> Contacts { get; set; }
    }
}
