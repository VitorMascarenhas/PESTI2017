using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Resolution
    {
        public int Id { get; set; }

        public string resolutionText { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        private Resolution() //EF
        {
            this.Tasks = new HashSet<Task>();
        }

        private Resolution(string resolution)
        {
            this.resolutionText = resolution;
        }
    }
}
