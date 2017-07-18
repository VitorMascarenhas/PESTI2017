using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlataformaRPHD.Web.ViewModels
{
    public class CreateRequestUserViewModel
    {
        public int Id { get; set; }
        
        public ICollection<AttachmentViewModel> attachments { get; set; }

        public User whoRegistered { get; set; }
        
        public User Owner { get; set; }

        [Display(Name = "Título do pedido")]
        public string Title { get; set; }

        [Display(Name = "Descrição do pedido")]
        public string Description { get; set; }
        
        public IEnumerable<CategoryViewModel> categories { get; set; }

        public IEnumerable<TopicViewModel> Topics { get; set; }

        public IEnumerable<ServiceViewModel> services { get; set; }

        public string sourceComputer { get; set; }

        [Display(Name = "Contacto telefónico")]
        public string contact { get; set; }

        public string origin { get; set; }
    }
}