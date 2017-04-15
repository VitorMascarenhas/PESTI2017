using System.Collections.Generic;

namespace PlataformaRPHD.DB.Domain
{
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Interaction> interactions { get; set; }

        private Service() // EF
        {
            this.interactions = new HashSet<Interaction>();
        }
    }
}
