using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public string text { get; set; }

        public virtual int HistoryMessageId { get; set; }

        public virtual HistoryMessage HistoryMessage { get; set; }

        public DateTime CreationTime { get; set; }

        private Message() //EF
        {
        }
    }
}
