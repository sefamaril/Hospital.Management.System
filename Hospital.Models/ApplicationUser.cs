using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Specialist { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Payroll> Payrolls { get; set; }
    }
}

namespace Hospital.Models
{
    public enum Gender
    {
        Male,Female,Other
    }
}