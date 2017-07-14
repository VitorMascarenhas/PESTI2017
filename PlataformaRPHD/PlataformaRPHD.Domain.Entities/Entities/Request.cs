using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Request
    {
        public int Id { get; set; }

        public virtual User WhoRegistered {get; set; }

        public virtual User Owner { get; set; }

        public DateTime TimeOfRegistration { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Interaction> Interactions { get; set; }
        
        public string sourceComputer { get; set; }

        public virtual ICollection<Attachment> attachments { get; set; }

        public string contact { get; set; }

        public string origin { get; set; }

        private Request() //EF
        {
            this.Interactions = new HashSet<Interaction>();
            this.attachments = new HashSet<Attachment>();
        }

        public Request(User WhoRegistered, User owner, string title, string description)
        {
            this.WhoRegistered = WhoRegistered;
            this.Owner = owner;
            this.Owner = owner;
            this.Title = title;
            this.Description = description;
        }

        public Request(User WhoRegistered, User Owner, string title, string description, ICollection<Interaction> interactions, ICollection<Attachment> attachments, string computer, string contact, string origin)
        {
            this.WhoRegistered = WhoRegistered;
            this.Owner = Owner;
            this.Title = title;
            this.Description = description;
            this.Interactions = interactions;
            this.attachments = attachments;
            this.sourceComputer = computer;
            this.TimeOfRegistration = new DateTime();
            this.origin = origin;
        }
    }
}
