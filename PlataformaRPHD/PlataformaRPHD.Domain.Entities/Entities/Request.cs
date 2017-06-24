using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Request
    {
        public int Id { get; set; }


        //public virtual int WhoRegisteredId { get; set; }

        public virtual User WhoRegistered {get; set; }

        //[ForeignKey("User")]
        //public virtual int OwnerId { get; set; }

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

        public Request(User WhoRegistered, User owner, string title, string description)
        {
            this.WhoRegistered = WhoRegistered;
            this.Owner = owner;
            this.Owner = owner;
            this.Title = title;
            this.Description = description;
        }
    }
}
