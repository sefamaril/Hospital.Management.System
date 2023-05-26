using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Payroll : Base
    {
        public decimal Salary { get; set; }
        public decimal NetSalary { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal BonusSalary { get; set; }
        public decimal Compensation { get; set; }
        public string AccountNumber { get; set; }

        public string EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual User Employee { get; set; }
    }
}