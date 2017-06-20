namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Attachment
    {
        public int Id { get; set; }

        public virtual Interaction Interaction { get; set; }

        private Attachment() //EF
        {
        }
    }
}
