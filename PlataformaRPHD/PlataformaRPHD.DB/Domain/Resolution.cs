using System.Collections.Generic;

namespace PlataformaRPHD.DB.Domain
{
    public class Resolution
    {
        public int Id { get; set; }

        public string resolutionText { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        private Resolution()
        {
            this.Tasks = new HashSet<Task>();
        }
    }
}
