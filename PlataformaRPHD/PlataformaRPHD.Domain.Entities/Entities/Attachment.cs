namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Attachment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual int RequestId { get; set; }

        public virtual Request Requests { get; set; }

        private Attachment() //EF
        {
        }
    }
}
