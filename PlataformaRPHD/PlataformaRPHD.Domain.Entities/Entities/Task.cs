using System;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Task
    {
        public int Id { get; set; }

        public virtual int OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public string status { get; set; }
        
        public virtual int InteractionId { get; set; }

        public virtual Interaction Interaction { get; set; }

        public virtual int HistoryOfTransfersId { get; set; }

        public virtual HistoryOfTransfers HistoryOfTransfers { get; set; }

        public virtual int historyChangeTaskStatusId { get; set; }

        public virtual HistoryChangeTaskStatus historyChangeTaskStatus { get; set; }
        
        public virtual int resolutionId { get; set; }

        public virtual Resolution resolution { get; set; }

        public bool close { get; set; }

        private Task() //EF
        {
        }

        public Task(User user, Interaction interaction)
        {
            this.Owner = user;
            this.status = "Aberto";
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
            if (!this.status.Equals(status)  && this.close == false)
            {
                if (status.Equals("Aberto"))
                {
                    OpenStatus os = new OpenStatus(this);
                    os.ChangeStatus();
                    this.historyChangeTaskStatus.AddTaskStatus(status);
                }
                else if (status.Equals("Fechado"))
                {
                    CloseStatus cs = new CloseStatus(this);
                    cs.ChangeStatus();
                    this.historyChangeTaskStatus.AddTaskStatus(status);
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
