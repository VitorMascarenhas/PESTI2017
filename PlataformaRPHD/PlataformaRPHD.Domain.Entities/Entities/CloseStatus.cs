using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class CloseStatus : TaskStatus
    {
        public string status = "Fechado";

        private Task _task;
        
        private CloseStatus() //EF
        {
        }

        public CloseStatus(Task task)
        {
            this._task = task;
        }

        public override void ChangeStatus()
        {
            this._task.status = this;
            this._task.close = true;
        }
    }
}
