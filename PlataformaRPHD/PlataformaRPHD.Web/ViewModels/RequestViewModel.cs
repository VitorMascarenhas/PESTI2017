using PlataformaRPHD.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaRPHD.Web.ViewModels
{
    public class RequestViewModel
    {
        public int Id { get; set; }

        public virtual User WhoRegistered { get; set; }

        public virtual User Owner { get; set; }

        public DateTime TimeOfRegistration { get; set; }

        public DateTime FromTimeOfRegistration { get; set; }

        public DateTime ToTimeOfRegistration { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Interaction> Interactions { get; set; }

        public virtual Category Category { get; set; }

        public string SourceComputer { get; set; }

        public virtual ICollection<Attachment> attachments { get; set; }

        public string Contact { get; set; }

        public virtual Origin Origin { get; set; }

        public virtual Impact Impact { get; set; }
    }
}