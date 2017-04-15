namespace PlataformaRPHD.DB.Domain
{
    public class Task
    {
        public int Id { get; set; }

        public int HistoryOfTransfersId { get; set; }

        public virtual HistoryOfTransfers HistoryOfTransfers { get; set; }

        public int interactionId { get; set; }

        public virtual Interaction Interaction { get; set; }

        public int resolutionId { get; set; }

        public virtual Resolution resolution { get; set; }

        private Task() // EF
        {
        }
    }
}
