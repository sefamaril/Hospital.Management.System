using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class TestPrice : Base
    {
        public string TestCode { get; set; }
        public decimal Price { get; set; }

        public Guid LabId { get; set; }
        [ForeignKey(nameof(LabId))]
        public virtual Lab Lab { get; set; }

        public Guid BillId { get; set; }
        [ForeignKey(nameof(BillId))]
        public virtual Bill Bill { get; set; }
    }
}
