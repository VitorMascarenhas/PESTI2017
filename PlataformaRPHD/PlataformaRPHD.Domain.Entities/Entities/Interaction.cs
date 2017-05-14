using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Interaction : IEntity
    {
        public virtual int Id { get; set; }

        public virtual Request Request { get; set; }

        public virtual Task Task { get; set; }

        public virtual Service service { get; set; }

        public virtual Topic Topic { get; set; }

        public virtual ICollection<Attachment> attachments { get; set; }

        public virtual HistoryMessage HistoryMessage { get; set; }

        private Interaction()
        {
            this.attachments = new HashSet<Attachment>();
        }

        public Interaction(Service service, Topic topic, Request request) : this()
        {
            this.service = service;
            this.Topic = topic;
            this.Request = request;
            this.HistoryMessage = new HistoryMessage();
        }
    }
}
