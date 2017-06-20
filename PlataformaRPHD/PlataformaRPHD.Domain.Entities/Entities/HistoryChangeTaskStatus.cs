using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class HistoryChangeTaskStatus
    {
        public int Id { get; set; }

        public virtual Dictionary<string, DateTime> History { get; set; }

        public HistoryChangeTaskStatus() //EF
        {
            this.History = new Dictionary<string, DateTime>();
        }

        public void AddTaskStatus(string status)
        {
            if (status == null)
            {
                throw new ArgumentNullException();
            }
            this.History.Add(status, new DateTime());
        }
    }
}
