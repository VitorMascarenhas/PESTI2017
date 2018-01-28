namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class PendingStatus
    {
        private Task _task;
        private string status;

        private PendingStatus() //EF
        {
            this.status = "Pendente";
        }

        public PendingStatus(Task task)
        {
            this._task = task;
        }

        public void ChangeStatus()
        {
            _task.Status = this.status;
        }
    }
}
