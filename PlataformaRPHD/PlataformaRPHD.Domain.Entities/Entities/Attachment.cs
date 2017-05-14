namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Attachment : IEntity
    {
        public virtual int Id { get; set; }

        public virtual Interaction Interaction { get; set; }
    }
}
