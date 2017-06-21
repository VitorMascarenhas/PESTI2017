using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class ChangeTaskStatus
    {
        public int Id { get; set; }

        public DateTime changed { get; set; }

        public virtual int UserId { get; set; }

        public virtual User auth { get; set; }

        public virtual int TaskId { get; set; }

        public virtual Task Task { get; set; }

        public TaskStatus TaskStatus { get; set; }

        public ChangeTaskStatus(int TaskId, TaskStatus taskStatus)
        {
            this.TaskId = TaskId;
            this.changed = new DateTime();
            this.TaskStatus = TaskStatus;
        }
    }
}
