namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Transfer
    {
        public int Id { get; set; }

        public virtual int OfUserId { get; set; }

        public virtual User OfUser { get; set; }

        public virtual int FromUserId { get; set; }

        public virtual User FromUser { get; set; }

        public virtual int WhoTransferredId { get; set; }

        public virtual User WhoTransferred { get; set; }

        public string description { get; set; }

        private Transfer() //EF
        {
        }

        public Transfer(User ofUser, User fromUser, User whoUser, string description)
        {
            this.OfUser = ofUser;
            this.FromUser = fromUser;
            this.WhoTransferred = whoUser;
            this.description = description;
        }
    }
}
