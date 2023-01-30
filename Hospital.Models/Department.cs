using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Employees { get; set; }
    }
}
