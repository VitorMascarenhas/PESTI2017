namespace PlataformaRPHD.Domain.Entities.Entities
{
    public abstract class TaskStatus
    {
        public int Id { get; set; }

        protected string status { get; set; }

        public abstract void ChangeStatus();
    }
}
