namespace PlataformaRPHD.DB.Domain
{
    public class UserName
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private UserName()
        {
        }

        public UserName(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }
    }
}
