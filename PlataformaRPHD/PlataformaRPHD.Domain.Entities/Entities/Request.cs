using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Request
    {
        public int Id { get; set; }

        public virtual int WhoRegisteredId { get; set; }

        public virtual User WhoRegistered { get; set; }

        public virtual int OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public DateTime TimeOfRegistration { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Interaction> Interactions { get; set; }
        
        public string sourceComputer { get; set; }

        private Request() //EF
        {
            this.Interactions = new HashSet<Interaction>();
        }

        public Request(User whoRegistered, User owner, string title, string description)
        {
            this.WhoRegistered = whoRegistered;
            this.Owner = owner;
            this.Title = title;
            this.Description = description;
        }
    }
}
