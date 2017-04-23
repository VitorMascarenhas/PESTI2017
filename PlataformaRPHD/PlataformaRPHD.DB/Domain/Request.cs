using System;
using System.Collections.Generic;

namespace PlataformaRPHD.DB.Domain
{
    public class Request
    {
        public int Id { get; set; }

        public int WhoRegisteredUserId { get; set; }

        public virtual User WhoRegistered { get; set; }

        public int OwneruserId { get; set; }

        public virtual User Owner { get; set; }

        public DateTime TimeOfRegistration { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Interaction> Interactions { get; set; }

        private Request() // EF
        {
            this.Interactions = new HashSet<Interaction>();
        }

        public Request(User whoRegistered, User owner, string title, string description) : this()
        {
            this.WhoRegistered = whoRegistered;
            this.Owner = owner;
            this.Title = title;
            this.Description = description;
        }
    }
}
