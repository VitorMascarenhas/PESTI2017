namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Notification
    {
        public int Id { get; set; }

        public Service Service { get; set; }

        public string OpenSubject { get; set; }

        public string CloseSubject { get; set; }

        public string OpenBody { get; set; }

        public string CloseBody { get; set; }
    }
}
