using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Insurance : Base
    {
        public string PolicyNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped]
        public ICollection<Bill> Bills { get; set; }
    }
}
