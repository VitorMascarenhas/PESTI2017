namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class SatisfactionSurvey
    {
        public int Id { get; set; }
        
        public string answer1 { get; set; }

        public string answer2 { get; set; }

        public  string suggestion{ get; set; }

        public bool closed { get; set; }

        public virtual int RequestId { get; set; }

        public virtual Request Request { get; set; }

        private SatisfactionSurvey() //EF
        {
        }

        public SatisfactionSurvey(Request request, string answer1, string answer2, string suggestion)
        {
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.suggestion = suggestion;
            this.closed = false;
            this.RequestId = request.Id;
        }
    }
}
