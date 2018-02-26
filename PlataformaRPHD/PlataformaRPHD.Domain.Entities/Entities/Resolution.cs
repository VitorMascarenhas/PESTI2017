using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Resolution
    {
        public int Id { get; set; }

        public string resolutionText { get; set; }

        public string ResolutionType { get; set; }

        public DateTime ResolutionDate { get; set; }

        public virtual ICollection<Task> Tasks { get; private set; }

        private Resolution() //EF
        {
            this.Tasks = new HashSet<Task>();
        }

        public Resolution(string resolution, string resolutionType) : this()
        {
            this.resolutionText = resolution;
            this.ResolutionType = ResolutionType;
            this.ResolutionDate = new DateTime();
            this.ResolutionDate = DateTime.Now;
        }

        public void AddTask(Task task)
        {
            if(task != null)
            {
                Tasks.Add(task);
            }
        }
    }
}
