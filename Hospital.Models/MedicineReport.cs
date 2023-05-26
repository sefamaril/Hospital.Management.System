using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class MedicineReport : Base
    {
        public string Company { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Country { get; set; }

        [NotMapped]
        public ICollection<Supplier> Suppliers { get; set; }
        [NotMapped]
        public ICollection<Medicine> Medicines { get; set; }
    }
}
