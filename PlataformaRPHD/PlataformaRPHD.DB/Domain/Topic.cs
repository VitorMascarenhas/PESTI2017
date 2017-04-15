namespace PlataformaRPHD.DB.Domain
{
    public class Topic
    {
        public int Id { get; set; }

        public int UpCategoryId { get; set; }

        public virtual Category UpCategory { get; set; }

        public int DownCategoryId { get; set; }

        public virtual Category DownCategory { get; set; }

        private Topic() // EF
        {
        }

        public Topic(int UpCategoryId, int DownCategoryId)
        {
            this.UpCategory.Id = UpCategoryId;
            this.DownCategory.Id = DownCategoryId;
        }

        public Topic(Category UpCategory, Category DownCategory)
        {
            this.UpCategory = UpCategory;
            this.DownCategory = DownCategory;
        }
    }
}
