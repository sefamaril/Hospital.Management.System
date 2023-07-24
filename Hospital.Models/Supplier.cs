using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Supplier : Base
    {
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Guid MedicineReportId { get; set; }
        [ForeignKey(nameof(MedicineReportId))]
        public virtual MedicineReport MedicineReport { get; set; }
    }
}
