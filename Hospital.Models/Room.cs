﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        [ForeignKey("HospitalInfo")]
        public int HospitalId { get; set; }
        public HospitalInfo Hospital { get; set; }
    }
}
