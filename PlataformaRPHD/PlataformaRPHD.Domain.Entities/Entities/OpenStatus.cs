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
            this.status = "Aberto";
            this._task = task;
        }

        public override string GetStatus()
        {
            return this.status;
        }

        public override void ChangeStatus()
        {
            this._task.status = this;
        }
    }
}
