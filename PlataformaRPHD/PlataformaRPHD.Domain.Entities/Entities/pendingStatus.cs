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
            this._task = task;
        }

        public void ChangeStatus()
        {
            _task.Status = "Pendente";
        }
    }
}
