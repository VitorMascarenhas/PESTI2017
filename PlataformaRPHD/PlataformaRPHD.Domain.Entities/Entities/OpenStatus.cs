namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class OpenStatus : ITaskStatus, IEntity
    {
        public virtual int Id { get; set; }

        public virtual string status { get; }

        private Task _task;

        public OpenStatus(Task task)
        {
            this._task = task;
            this.status = "Aberto";
        }

        public string GetTypeStatus()
        {
            return this.status;
        }

        public void ChangeStatus()
        {
            this._task.status = this;
        }
    }
}
