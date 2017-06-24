using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Interaction
    {
        public int Id { get; set; }

        public virtual int RequestId { get; set; }

        public virtual Request Request { get; set; }

        public virtual int serviceId { get; set; }

        public virtual Service service { get; set; }

        public virtual int TopicId { get; set; }

        public virtual Topic Topic { get; set; }

        public virtual ICollection<Attachment> attachments { get; set; }
        
        public virtual ICollection<Message> HistoryMessages { get; set; }

        private Interaction() //EF
        {
            this.attachments = new HashSet<Attachment>();
            this.HistoryMessages = new List<Message>();
        }

        public Interaction(Service service, Topic topic, Request request) : this()
        {
            this.service = service;
            this.Topic = topic;
            this.Request = request;
        }
    }
}
