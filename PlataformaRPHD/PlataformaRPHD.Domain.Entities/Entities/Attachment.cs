using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Attachment
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public virtual Request Request { get; set; }

        private Attachment() //EF
        {
        }
    }
}
