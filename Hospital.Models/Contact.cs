using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Contact : Base
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        public Guid HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public virtual HospitalInfo HospitalInfo { get; set; }

    }
}
