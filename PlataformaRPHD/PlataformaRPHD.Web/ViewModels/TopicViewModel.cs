namespace PlataformaRPHD.Web.ViewModels
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        
        public CategoryViewModel UpCategory { get; set; }
        
        public CategoryViewModel DownCategory { get; set; }
    }
}