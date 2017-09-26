using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class CloseStatus : TaskStatus
    {
        private Task _task;
        
        private CloseStatus() //EF
        {
        }

        public CloseStatus(Task task)
        {
            this.status = "Fechado";
            this._task = task;
        }

        public override void ChangeStatus()
        {
            this._task.status = this;
            this._task.close = true;
        }
    }
}
