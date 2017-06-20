namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class UserStatus
    {
        public int Id { get; set; }

        public string Status { get; set; }

        private UserStatus() //EF
        {
        }

        public UserStatus(string userStatus)
        {
            this.Status = userStatus;
        }
    }
}
