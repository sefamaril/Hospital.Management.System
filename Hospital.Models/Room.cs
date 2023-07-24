using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Room : Base
    {
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public Guid HospitalId { get; set; }
        [ForeignKey(nameof(HospitalId))]
        public virtual HospitalInfo HospitalInfo { get; set; }
    }
}
