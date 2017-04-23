using System;

namespace PlataformaRPHD.DB.Domain
{
    public class CloseStatus : ITaskStatus
    {
        private int Id { get; set; }

        private string status { get; set; }

        private Task _tasK;

        public CloseStatus(Task task)
        {
            this.status = "Fechado";
            this._tasK = task;
        }

        public string GetTypeStatus()
        {
            return this.status;
        }

        public void ChangeStatus()
        {
            this._tasK.status = this;
            this._tasK.close = true;
        }
    }
}
