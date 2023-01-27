namespace Hospital.Models
{
    public class Supplier
    {
        public string Id { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public ICollection<MedicineReport> MedicineReport { get; set; }
    }
}
