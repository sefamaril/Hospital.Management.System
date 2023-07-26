using Hospital.Models;

namespace Hospital.ViewModels
{
    public class RoomViewModel
    {
        public Guid Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public Guid HospitalInfoId { get; set; }

        public RoomViewModel()
        {

        }
        public RoomViewModel(Room model)
        {
            Id = model.Id;
            RoomNumber = model.RoomNumber;
            Type = model.Type;
            Status = model.Status;
            HospitalInfoId = Guid.NewGuid();
        }
        public Room ConvertViewModel(RoomViewModel model)
        {
            return new Room
            {
                Id = model.Id,
                Type = model.Type,
                RoomNumber = model.RoomNumber,
                Status = model.Status,
                HospitalId = Guid.NewGuid()

            };
        }
    }
}
