using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Lab : Base
    {
        public string LabNumber { get; set; }
        public string TestType { get; set; }
        public string TestCode { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int BloodPressure { get; set; }
        public int Temperature { get; set; }
        public string TestResult { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User Patient { get; set; }
    }
}