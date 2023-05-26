using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Bill : Base
    {
        public int BillNumber { get; set; }
        public decimal DoctorCharge { get; set; }
        public decimal MedicineCharge { get; set; }
        public decimal RoomCharge { get; set; }
        public decimal OperationCharge { get; set; }
        public int NoOfDays { get; set; }
        public decimal NursingCharge { get; set; }
        public decimal LabCharge { get; set; }
        public decimal Advance { get; set; }
        public decimal TotalBill { get; set; }

        public string PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual User Patient { get; set; }

        public Guid InsuranceId { get; set; }
        [ForeignKey("InsuranceId")]
        public virtual Insurance Insurance { get; set; }
    }
}