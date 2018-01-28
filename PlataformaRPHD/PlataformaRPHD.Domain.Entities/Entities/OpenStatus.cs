using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class OpenStatus
    {
        private Task _task;
        private string status;

        private OpenStatus() //EF
        {
            this.status = "Aberto";
        }

        public OpenStatus(Task task) : this()
        {
            this._task = task;
        }
        
        public void ChangeStatus()
        {
            this._task.Status = status;
        }
    }
}
