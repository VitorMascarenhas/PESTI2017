using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        
        //public virtual int UpCategoryId { get; set; }
        //[ForeignKey("UpCategoryId")]
        public virtual Category UpCategory { get; set; }
        
        //public virtual int DownCategoryId { get; set; }
        //[ForeignKey("DownCategoryId")]
        public virtual Category DownCategory { get; set; }

        private Topic() //EF
        {
        }
        
        public Topic(Category UpCategory, Category DownCategory)
        {
            this.UpCategory = UpCategory;
            this.DownCategory = DownCategory;
        }
    }
}
