namespace PlataformaRPHD.DB.Domain
{
    public class OpenStatus : ITaskStatus
    {
        public int Id { get; set; }

        public string status { get; }

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
