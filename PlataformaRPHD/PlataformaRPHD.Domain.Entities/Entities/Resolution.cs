using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Resolution : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string resolutionText { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        private Resolution()
        {
            this.Tasks = new HashSet<Task>();
        }
    }
}
