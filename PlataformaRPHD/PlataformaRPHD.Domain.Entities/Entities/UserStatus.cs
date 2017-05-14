namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class UserStatus : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Status { get; set; }

        private UserStatus()
        {
        }

        public UserStatus(string userStatus)
        {
            this.Status = userStatus;
        }
    }
}
