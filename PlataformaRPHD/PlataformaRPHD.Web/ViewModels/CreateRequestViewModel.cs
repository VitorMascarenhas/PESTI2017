using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Web.ViewModels
{
    public class CreateRequestViewModel
    {
        public int Id { get; set; }

        public ICollection<AttachmentViewModel> attachments { get; set; }

        public User whoRegistered { get; set; }

        public User Owner { get; set; }

        [Required(ErrorMessage = "Escreva um título."), Column(Order = 1)]
        public string Title { get; set; }

        public string Description { get; set; }
        
        public int Category1Id { get; set; }

        public int Category2Id { get; set; }

        public int Category3Id { get; set; }

        public int Category4Id { get; set; }

        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Digite um contacto."), Column(Order = 1)]
        public string Contact { get; set; }

        public int OriginId { get; set; }

        public int ImpactId { get; set; }
    }
}