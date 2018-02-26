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
            this._task = task;
        }

        public void ChangeStatus()
        {
            _task.Status = "Fechado";
            this._task.close = true;
        }
    }
}
