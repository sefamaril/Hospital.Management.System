using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class PatientReport
    {
        public int Id { get; set; }
        public string Diagnose { get; set; }
       // public string MedicineName { get; set; }
        public User Doctor { get; set; }
        public User Patient { get; set; }
        public ICollection<PrescribedMedicine> PrescribedMedicine { get; set; }
    }
}
