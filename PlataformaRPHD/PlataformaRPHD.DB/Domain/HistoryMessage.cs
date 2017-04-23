using System.Collections.Generic;

namespace PlataformaRPHD.DB.Domain
{
    public class HistoryMessage
    {
        public int Id { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public int interactionId { get; set; }

        public virtual Interaction Interaction { get; set; }

        private HistoryMessage() // EF
        {
            this.Messages = new HashSet<Message>();
        }

        public HistoryMessage(int interactionId) : this()
        {
            this.interactionId = interactionId;
        }
    }
}
