using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Medicine : Base
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public Guid MedicineReportId { get; set; }
        [ForeignKey("MedicineReportId")]
        public virtual MedicineReport MedicineReport { get; set; }

        public Guid PrescribedMedicineId { get; set; }
        [ForeignKey(nameof(PrescribedMedicineId))]
        public virtual PrescribedMedicine PrescribedMedicine { get; set; }
    }
}
