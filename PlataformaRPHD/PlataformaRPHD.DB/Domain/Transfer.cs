using System;

namespace PlataformaRPHD.DB.Domain
{
    public class Transfer
    {
        public int Id { get; set; }

        public int OfUserId { get; set; }

        public virtual User OfUser { get; set; }

        public int FromUserId { get; set; }

        public virtual User FromUser { get; set; }

        public int WhoUserId { get; set; }

        public virtual User WhoTransferred { get; set; }

        public string description { get; set; }

        private Transfer() // EF
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
