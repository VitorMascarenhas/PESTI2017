using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;

namespace PlataformaRPHD.Web.ViewModels
{
    public class InteractionViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Request Request { get; set; }

        public Service service { get; set; }

        public ICollection<Message> HistoryMessages { get; set; }

        public TaskViewModel Task { get; set; }

        public string userId { get; set; }

        public string Description { get; set; }

        public string statusDescription { get; set; }

        public string statusId { get; set; }

        public string ResolutionText { get; set; }

        public string ResolutionType { get; set; }
    }
}