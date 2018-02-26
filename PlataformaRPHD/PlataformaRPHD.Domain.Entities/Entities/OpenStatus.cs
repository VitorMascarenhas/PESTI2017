using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class OpenStatus : TaskStatus
    {
        private Task _task;

        private OpenStatus() //EF
        {
        }

        public OpenStatus(Task task)
        {
            this._task = task;
        }
        
        public void ChangeStatus()
        {
            this._task.Status = "Aberto";
        }
    }
}
