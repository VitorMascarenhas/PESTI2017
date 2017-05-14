using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Task : IEntity
    {
        public virtual int Id { get; set; }
        
        public virtual User Owner { get; set; }

        public ITaskStatus status { get; set; }

        public virtual Interaction Interaction { get; set; }
        
        public virtual HistoryOfTransfers HistoryOfTransfers { get; set; }
        
        public virtual HistoryChangeTaskStatus historyChangeTaskStatus { get; set; }
        
        public virtual Resolution resolution { get; set; }

        public bool close { get; set; }

        private Task()
        {
        }

        public Task(User user, Interaction interaction)
        {
            this.Owner = user;
            this.status = new OpenStatus(this);
            this.Interaction = interaction;
            this.HistoryOfTransfers = new HistoryOfTransfers();
            this.historyChangeTaskStatus = new HistoryChangeTaskStatus();
            this.historyChangeTaskStatus.AddTaskStatus(this.status);
            this.close = false;
        }

        /// <summary>
        /// Create a instance of TaskStatus and add to historyChageTaskStatus
        /// </summary>
        /// <param name="status"></param>
        public void ChangeStatus(string status)
        {
            if (string.IsNullOrEmpty(status))
            {
                throw new ArgumentNullException();
            }
            if (!this.status.GetTypeStatus().Equals(status) && this.close == false)
            {
                if (status.Equals("Aberto"))
                {
                    OpenStatus os = new OpenStatus(this);
                    os.ChangeStatus();
                    this.historyChangeTaskStatus.AddTaskStatus(os);
                }
                else if (status.Equals("Fechado"))
                {
                    CloseStatus cs = new CloseStatus(this);
                    cs.ChangeStatus();
                    this.historyChangeTaskStatus.AddTaskStatus(cs);
                }
            }
        }

        public void Transfer(User forUser, User whoUser, string description)
        {
            Transfer transfer = new Transfer(this.Owner, forUser, whoUser, description);
            this.Owner = forUser;
            this.HistoryOfTransfers.AddTransfer(transfer);
        }
    }
}
