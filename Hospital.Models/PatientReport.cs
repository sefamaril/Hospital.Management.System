using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class PatientReport : Base
    {
        public string Diagnose { get; set; }

        public string DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual User Doctor { get; set; }

        public string PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual User Patient { get; set; }
        [NotMapped]
        public ICollection<PrescribedMedicine> PrescribedMedicines { get; set; }
    }
}
