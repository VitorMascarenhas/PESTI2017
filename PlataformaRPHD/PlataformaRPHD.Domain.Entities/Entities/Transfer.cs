namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Transfer : IEntity
    {
        public virtual int Id { get; set; }
        
        public virtual User OfUser { get; set; }
        
        public virtual User FromUser { get; set; }
        
        public virtual User WhoTransferred { get; set; }

        public virtual string description { get; set; }

        private Transfer()
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
