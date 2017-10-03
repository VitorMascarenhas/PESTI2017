namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class PendingStatus : TaskStatus
    {
        private Task _task;

        private PendingStatus() //EF
        {
        }

        public PendingStatus(Task task)
        {
            this.status = "Pendente";
            this._task = task;
        }

        public override void ChangeStatus()
        {
            this._task.status = this;
        }

        public override string GetStatus()
        {
            return this.status;
        }
    }
}
