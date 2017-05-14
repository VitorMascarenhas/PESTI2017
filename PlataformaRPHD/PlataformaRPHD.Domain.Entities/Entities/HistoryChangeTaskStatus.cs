using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class HistoryChangeTaskStatus : IEntity
    {
        public virtual int Id { get; set; }

        public virtual Dictionary<ITaskStatus, DateTime> History { get; set; }

        public virtual Task Task { get; set; }

        public HistoryChangeTaskStatus()
        {
            this.History = new Dictionary<ITaskStatus, DateTime>();
        }

        public void AddTaskStatus(ITaskStatus taskStatus)
        {
            if (taskStatus == null)
            {
                throw new ArgumentNullException();
            }
            this.History.Add(taskStatus, new DateTime());
        }
    }
}
