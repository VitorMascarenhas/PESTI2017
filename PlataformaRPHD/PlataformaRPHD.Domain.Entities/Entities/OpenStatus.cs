namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class OpenStatus : TaskStatus
    {
        public string status = "Aberto";

        private Task _task;

        public OpenStatus(Task task)
        {
            this._task = task;
        }

        public string GetStatus()
        {
            return this.status;
        }

        public override void ChangeStatus()
        {
            this._task.status = this;
        }
    }
}
