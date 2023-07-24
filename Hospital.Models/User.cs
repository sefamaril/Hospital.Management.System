﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Specialist { get; set; }

        public Guid DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }

        [NotMapped]
        public ICollection<Appointment> Appointments { get; set; }

        [NotMapped]
        public ICollection<Payroll> Payrolls { get; set; }
    }
}

namespace Hospital.Models
{
    public enum Gender
    {
        Male, Female, Other
    }
}