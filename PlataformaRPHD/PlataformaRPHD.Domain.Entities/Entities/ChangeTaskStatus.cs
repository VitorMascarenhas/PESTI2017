using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class ChangeTaskStatus
    {
        public int Id { get; set; }

        public DateTime changed { get; set; }

        public string Description { get; set; }

        public virtual int UserId { get; set; }

        public virtual User auth { get; set; }
        
        public virtual Task Task { get; set; }

        public string Status { get; set; }

        private ChangeTaskStatus() //EF
        {
        }

        public ChangeTaskStatus(string status)
        {
            this.Status = status;
            this.changed = new DateTime();
            this.changed = DateTime.Now;
        }
    }
}
