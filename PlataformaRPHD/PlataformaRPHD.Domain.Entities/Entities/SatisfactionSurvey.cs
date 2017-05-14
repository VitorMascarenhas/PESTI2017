namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class SatisfactionSurvey : IEntity
    {
        public virtual int Id { get; set; }
        
        public virtual Request Request { get; set; }

        private SatisfactionSurvey()
        {
        }
    }
}
