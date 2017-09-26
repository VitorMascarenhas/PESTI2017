using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class ChangeTaskStatus
    {
        public int Id { get; set; }

        public DateTime changed { get; set; }

        public virtual int UserId { get; set; }

        public virtual User auth { get; set; }
        
        public virtual Task Task { get; set; }

        public TaskStatus TaskStatus { get; set; }

        private ChangeTaskStatus() //EF
        {
        }

        public ChangeTaskStatus(/*int TaskId,*/ TaskStatus taskStatus)
        {
            //this.TaskId = TaskId;
            this.TaskStatus = TaskStatus;
        }
    }
}
