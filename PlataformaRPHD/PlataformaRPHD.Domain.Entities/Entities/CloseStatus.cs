using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class CloseStatus
    {
        private Task _task;
        private string status;

        private CloseStatus() //EF
        {
            this.status = "Fechado";
        }

        public CloseStatus(Task task)
        {
            this._task = task;
        }

        public void ChangeStatus()
        {
            _task.Status = this.status;
            this._task.close = true;
        }
    }
}
