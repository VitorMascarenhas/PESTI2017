using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Task
    {
        public int Id { get; set; }
        
        public virtual User Owner { get; set; }

        public string Status { get; set; }
        
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
            this.close = false;
            OpenStatus os = new OpenStatus(this);
            os.ChangeStatus();
            ChangeTaskStatus cts = new ChangeTaskStatus(this.Status);
            HistoryChangeStatus.Add(cts);
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
            if (!this.Status.Equals(status)  && this.close == false)
            {
                if (status.Equals("Aberto"))
                {
                    OpenStatus os = new OpenStatus(this);
                    os.ChangeStatus();
                    ChangeTaskStatus cts = new ChangeTaskStatus(status);
                    this.HistoryChangeStatus.Add(cts);
                }
                else if (status.Equals("Fechado"))
                {
                    CloseStatus cs = new CloseStatus(this);
                    cs.ChangeStatus();
                    ChangeTaskStatus cts = new ChangeTaskStatus(status);
                    this.HistoryChangeStatus.Add(cts);
                }
                else if (status.Equals("Pendente"))
                {
                    PendingStatus ps = new PendingStatus(this);
                    ps.ChangeStatus();
                    ChangeTaskStatus cts = new ChangeTaskStatus(status);
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
