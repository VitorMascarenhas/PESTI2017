using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public string text { get; set; }

        public DateTime CreationTime { get; set; }

        public virtual int UserId { get; set; }

        public virtual User auth { get; set; }

        public virtual int InteractionId { get; set; }

        public virtual Interaction Interaction { get; set; }

        private Message() //EF
        {
        }
    }
}
