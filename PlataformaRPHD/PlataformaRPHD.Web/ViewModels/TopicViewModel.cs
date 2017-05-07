namespace PlataformaRPHD.Web.ViewModels
{
    public class TopicViewModel
    {
        public int Id { get; set; }

        public int UpCategoryId { get; set; }

        public virtual CategoryViewModel UpCategory { get; set; }

        public int DownCategoryId { get; set; }

        public virtual CategoryViewModel DownCategory { get; set; }
    }
}