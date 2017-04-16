using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class TopicEntityConfiguration : EntityTypeConfiguration<Topic>
    {
        public TopicEntityConfiguration()
        {
            this.HasKey(k => k.Id);
            Property(p => p.UpCategoryId).IsRequired();
            Property(p => p.DownCategoryId).IsRequired();
        }
    }
}
