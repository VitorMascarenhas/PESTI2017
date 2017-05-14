namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Topic : IEntity
    {
        public virtual int Id { get; set; }
        
        public virtual Category UpCategory { get; set; }
        
        public virtual Category DownCategory { get; set; }

        private Topic()
        {
        }
        
        public Topic(Category UpCategory, Category DownCategory)
        {
            this.UpCategory = UpCategory;
            this.DownCategory = DownCategory;
        }
    }
}
