namespace PlataformaRPHD.DB.Domain
{
    public class UserStatus
    {
        public int Id { get; set; }

        public string Status { get; set; }

        private UserStatus() // EF
        {
        }

        public UserStatus(string userStatus)
        {
            this.Status = userStatus;
        }
    }
}
