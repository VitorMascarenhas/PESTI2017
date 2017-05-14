namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class CloseStatus : ITaskStatus, IEntity
    {
        public virtual int Id { get; set; }

        public virtual string status { get; set; }

        private Task _task;

        public CloseStatus(Task task)
        {
            this.status = "Fechado";
            this._task = task;
        }

        public string   GetTypeStatus()
        {
            return this.status;
        }

        public void ChangeStatus()
        {
            this._task.status = this;
            this._task.close = true;
        }
    }
}
