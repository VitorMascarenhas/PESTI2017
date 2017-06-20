namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class CloseStatus : ITaskStatus
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
            _task.status = "Fechado";
            this._task.close = true;
        }
    }
}
