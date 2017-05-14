using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Message : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string text { get; set; }

        public virtual HistoryMessage HistoryMessage { get; set; }

        public virtual DateTime CreationTime { get; set; }

        private Message()
        {
        }
    }
}
