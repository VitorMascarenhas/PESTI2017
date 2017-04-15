namespace PlataformaRPHD.DB.Domain
{
    public class TaskStatus
    {
        public int Id { get; set; }

        public string Status { get; set; }

        private TaskStatus() // EF
        {
        }
    }
}
