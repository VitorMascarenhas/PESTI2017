using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class HistoryMessage
    {
        public int Id { get; set; }

        public virtual ICollection<Message> Messages { get; private set; }
        
        public HistoryMessage() //EF
        {
            Messages = new HashSet<Message>();
        }
    }
}
