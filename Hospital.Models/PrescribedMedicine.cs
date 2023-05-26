using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class PrescribedMedicine : Base
    {
        public Guid MedicineId { get; set; }
        [ForeignKey(nameof(MedicineId))]
        public virtual Medicine Medicine { get; set; }

        public Guid PatientReportId { get; set; }
        [ForeignKey(nameof(PatientReportId))]
        public virtual PatientReport PatientReport { get; set; }
    }
}
