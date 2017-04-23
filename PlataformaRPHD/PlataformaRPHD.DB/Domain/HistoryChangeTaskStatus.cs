using PlataformaRPHD.DB.Domain;
using System;
using System.Collections.Generic;

namespace PlataformaRPHD.DB.Domain
{
    public class HistoryChangeTaskStatus
    {
        public int Id { get; set; }

        public Dictionary<ITaskStatus, DateTime> History  { get; set; }

        public HistoryChangeTaskStatus() // EF
        {
            this.History = new Dictionary<ITaskStatus, DateTime>();
        }

        public void AddTaskStatus(ITaskStatus taskStatus)
        {
            if(taskStatus == null)
            {
                throw new ArgumentNullException();
            }
            this.History.Add(taskStatus, new DateTime());
        }
    }
}
