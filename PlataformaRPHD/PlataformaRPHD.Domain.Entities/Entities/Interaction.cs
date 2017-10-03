using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Interaction
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public virtual Request Request { get; set; }
        
        public virtual Service service { get; set; }
        
        public virtual Task Task { get; set; }

        public virtual ICollection<Message> HistoryMessages { get; set; }
        
        private Interaction() //EF
        {
            this.HistoryMessages = new List<Message>();
        }

        public Interaction(Service service, Request request) : this()
        {
            this.service = service;
            this.Request = request;
        }

        public Interaction(string title, Service service)
        {
            this.Title = title;
            this.service = service;
            this.Task = new Task();
        }
    }
}
