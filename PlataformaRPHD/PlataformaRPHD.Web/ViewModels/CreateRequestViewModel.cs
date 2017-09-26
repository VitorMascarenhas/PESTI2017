using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlataformaRPHD.Web.ViewModels
{
    public class CreateRequestViewModel
    {
        public int Id { get; set; }

        public ICollection<AttachmentViewModel> attachments { get; set; }

        public User whoRegistered { get; set; }

        public User Owner { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IEnumerable<CategoryViewModel> categories { get; set; }

        public IEnumerable<TopicViewModel> Topics { get; set; }

        public IEnumerable<ServiceViewModel> services { get; set; }

        [Range(1000, 999999999)]
        public string contact { get; set; }

        public string origin { get; set; }
    }
}