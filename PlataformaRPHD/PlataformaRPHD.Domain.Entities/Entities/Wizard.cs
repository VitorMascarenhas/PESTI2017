namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Wizard
    {
        #region Properties

        public int Id { get; set; }

        public string Title { get; set; }

        public User CreateBy { get; set; }

        public Step Step { get; set; }
        
        public bool Approved { get; set; }

        #endregion

        private Wizard() // For EF
        {
        }

        public Wizard(string title)
        {
            this.Title = title;
        }

        public Wizard(string title, Step step)
        {
            this.Title = title;
            this.Step = step;
            this.Approved = false;
        }

        public void Approv()
        {
            this.Approved = true;
        }
    }
}
