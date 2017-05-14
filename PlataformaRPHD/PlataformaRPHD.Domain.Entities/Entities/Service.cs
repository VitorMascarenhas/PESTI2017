using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Service : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public Service()
        {
        }
    }
}
