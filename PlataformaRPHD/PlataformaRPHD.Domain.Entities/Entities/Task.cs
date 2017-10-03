using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Task
    {
        public int Id { get; set; }
        
        public virtual User Owner { get; set; }

        public TaskStatus status { get; set; }
        
        public ICollection<Transfer> Transfers { get; set; }

        public ICollection<ChangeTaskStatus> HistoryChangeStatus { get; set; }
        
        public virtual Resolution Resolution { get; set; }

        public bool close { get; set; }

        public Task() //EF
        {
            this.HistoryChangeStatus = new List<ChangeTaskStatus>();
            this.Transfers = new List<Transfer>();
        }
        
        public Task(User user, Interaction interaction) : this()
        {
            this.Owner = user;
            this.status = new OpenStatus(this);
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
                    ChangeTaskStatus cts = new ChangeTaskStatus(/*this.Id,*/ os);
                    this.HistoryChangeStatus.Add(cts);
                }
                else if (status.Equals("Fechado"))
                {
                    PendingStatus cs = new PendingStatus(this);
                    cs.ChangeStatus();
                    ChangeTaskStatus cts = new ChangeTaskStatus(/*this.Id,*/ cs);
                    this.HistoryChangeStatus.Add(cts);
                }
            }
        }

        public void Transfer(User forUser, User whoUser, string description)
        {
            Transfer transfer = new Transfer(this.Id, this.Owner, forUser, whoUser, description);
            this.Transfers.Add(transfer);
        }
    }
}
