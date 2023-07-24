using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Appointment : Base
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Description { get; set; }

        public string DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual User Doctor { get; set; }

        public string PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual User Patient { get; set; }
    }
}