namespace PlataformaRPHD.DB.Domain
{
    public class SatisfactionSurvey
    {
        public int Id { get; set; }

        public int RequestId { get; set; }

        public virtual Request Request { get; set; }

        private SatisfactionSurvey() // EF
        {
        }
    }
}
