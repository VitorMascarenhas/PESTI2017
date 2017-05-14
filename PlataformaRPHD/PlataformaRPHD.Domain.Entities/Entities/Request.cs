using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Request : IEntity
    {
        public virtual int Id { get; set; }

        public virtual User WhoRegistered { get; set; }

        public virtual User Owner { get; set; }

        public virtual DateTime TimeOfRegistration { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual ICollection<Interaction> Interactions { get; set; }
        
        public virtual string sourceComputer { get; set; }

        private Request()
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
