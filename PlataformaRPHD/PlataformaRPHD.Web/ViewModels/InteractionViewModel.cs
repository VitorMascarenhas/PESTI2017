using System.Collections.Generic;

namespace PlataformaRPHD.Web.ViewModels
{
    public class InteractionViewModel
    {
        public int Id { get; set; }

        public virtual ICollection<ServiceViewModel> service { get; set; }
        
        public virtual ICollection<CategoryViewModel> Category { get; set; }

        public virtual ICollection<AttachmentViewModel> attachments { get; set; }

        public int historyMessageId { get; set; }

        public HistoryMessageViewModel HistoryMessage { get; set; }
    }
}