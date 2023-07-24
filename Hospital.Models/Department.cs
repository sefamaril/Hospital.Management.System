using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Department : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public ICollection<User> Employees { get; set; }
    }
}
