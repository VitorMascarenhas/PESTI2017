using System.Collections.Generic;

namespace PlataformaRPHD.DB.Domain
{
    public class Interaction
    {
        public int Id { get; set; }

        public int requestId { get; set; }

        public virtual Request Request { get; set; }

        public int taskId { get; set; }

        public virtual Task Task { get; set; }

        public int serviceId { get; set; }

        public virtual Service service { get; set; }

        public int categoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Attachment> attachments { get; set; }

        public int historyMessageId { get; set; }

        public virtual HistoryMessage HistoryMessage { get; set; }

        private Interaction() //EF
        {
            this.attachments = new HashSet<Attachment>();
        }

        public Interaction(int serviceId, int cattegoryId, int requestId) : this()
        {
            this.serviceId = serviceId;
            this.categoryId = categoryId;
            this.requestId = requestId;
            this.HistoryMessage = new HistoryMessage(this.historyMessageId);
        }
    }
}
