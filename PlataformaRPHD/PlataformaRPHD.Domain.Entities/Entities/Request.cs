using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Request
    {
        public int Id { get; set; }
        
        public virtual User WhoRegistered {get; set; }
        
        public virtual User Owner { get; set; }

        public virtual DateTime TimeOfRegistration { get; set; }

        public string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual ICollection<Interaction> Interactions { get; private set; }
        
        public virtual Category Category { get; set; }

        public virtual string SourceComputer { get; set; }

        public virtual ICollection<Attachment> attachments { get; private set; }

        public virtual string Contact { get; set; }

        public virtual Origin Origin { get; set; }

        public virtual Impact Impact { get; set; }

        private Request() //EF
        {
            this.Interactions = new HashSet<Interaction>();
            this.attachments = new HashSet<Attachment>();
        }

        public Request(User WhoRegistered, User owner, string title, string description) : this()
        {
            this.WhoRegistered = WhoRegistered;
            this.Owner = owner;
            this.Title = title;
            this.Description = description;
        }

        public Request(User WhoRegistered, User Owner, string title, string description, Category category, string computer, string contact, Origin origin, Impact impact) : this()
        {
            this.WhoRegistered = WhoRegistered;
            this.Owner = Owner;
            this.Contact = contact;
            this.Title = title;
            this.Description = description;
            this.Category = category;
            this.SourceComputer = computer;
            this.TimeOfRegistration = new DateTime();
            this.Origin = origin;
            this.TimeOfRegistration = DateTime.Now;
            this.Impact = impact;
        }

        public void AddAttachment(Attachment attachment)
        {
            this.attachments.Add(attachment);
        }

        public void AddInteraction(Interaction interaction)
        {
            this.Interactions.Add(interaction);
        }
    }
}
