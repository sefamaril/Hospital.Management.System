namespace Hospital.Models
{
    public class Base
    {
        public Guid Id { get; set; }
        public Guid CreatedUser { get; set; }
        public Guid? ModifedUser { get; set; }
        public Guid? DeletedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? DeletedTime { get; set; }

        public void SetCreatInfo(Guid createdUser)
        {
            CreatedUser = createdUser;
            CreatedTime = DateTime.UtcNow;
        }

        public void SetModifyInfo(Guid modifiedUser)
        {
            ModifedUser = modifiedUser;
            ModifiedTime = DateTime.UtcNow;
        }

        public void SetDeleteInfo(Guid deletedUser)
        {
            DeletedUser = deletedUser;
            DeletedTime = DateTime.UtcNow;
        }

    }

}
