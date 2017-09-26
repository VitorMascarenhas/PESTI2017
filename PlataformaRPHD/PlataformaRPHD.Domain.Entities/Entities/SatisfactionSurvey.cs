namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class SatisfactionSurvey
    {
        public int Id { get; set; }
        
        public virtual int RequestId { get; set; }

        public virtual Request Request { get; set; }

        private SatisfactionSurvey() //EF
        {
        }
    }
}
