using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Transfer
    {
        public int Id { get; set; }
        
        public virtual User OfUser { get; set; }

        public virtual User FromUser { get; set; }
        
        public virtual User WhoTransferred { get; set; }

        public string description { get; set; }

        public DateTime tranfered { get; set; }

        public virtual int TaskId { get; set; }

        public virtual Task Task { get; set; }

        private Transfer() //EF
        {
        }

        public Transfer(Task task, User ofUser, User fromUser, User whoUser, string description)
        {
            this.Task = task;
            this.OfUser = ofUser;
            this.FromUser = fromUser;
            this.WhoTransferred = whoUser;
            this.description = description;
            this.tranfered = new DateTime();
            this.tranfered = DateTime.Now;
        }
    }
}
