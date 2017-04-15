namespace PlataformaRPHD.DB.Domain
{
    public class Attachment
    {
        public int Id { get; set; }

        public int interactionId { get; set; }

        public virtual Interaction Interaction { get; set; }
    }
}
