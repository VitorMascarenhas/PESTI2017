using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlataformaRPHD.Web.ViewModels
{
    public class CreateRequestViewModel
    {
        public int Id { get; set; }

        public int WhoRegisteredUserId { get; set; }

        public virtual UserViewModel WhoRegistered { get; set; }

        public int OwneruserId { get; set; }

        public virtual UserViewModel Owner { get; set; }

        public DateTime TimeOfRegistration { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<InteractionViewModel> Interactions { get; set; }

        public virtual IEnumerable<CategoryViewModel> categories { get; set; }
    }
}