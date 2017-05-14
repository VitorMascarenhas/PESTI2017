using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class HistoryMessage : IEntity
    {
        public virtual int Id { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        
        public virtual Interaction Interaction { get; set; }

        public HistoryMessage()
        {
            this.Messages = new HashSet<Message>();
        }
    }
}
