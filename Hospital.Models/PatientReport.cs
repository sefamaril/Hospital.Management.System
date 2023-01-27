using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class PatientReport
    {
        public int Id { get; set; }
        public string Diagnose { get; set; }
        public string MedicineName { get; set; }
        [NotMapped]
        public ApplicationUser Doctor { get; set; }
        [NotMapped]
        public ApplicationUser Patient { get; set; }
        public ICollection<PrescribedMedicine> PrescribedMedicine { get; set; }
    }
}
