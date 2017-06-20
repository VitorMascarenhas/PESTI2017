namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class OpenStatus : ITaskStatus
    {
        private Task _task;

        public OpenStatus(Task task)
        {
            this._task = task;
        }

        public void ChangeStatus()
        {
            this._task.status = "Aberto";
        }
    }
}
