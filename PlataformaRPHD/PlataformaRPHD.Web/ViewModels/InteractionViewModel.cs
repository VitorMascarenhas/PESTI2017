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
    }
}