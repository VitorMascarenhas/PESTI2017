using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class RequestEntityConfiguration : EntityTypeConfiguration<Request>
    {
        public RequestEntityConfiguration()
        {
            this.HasKey(k => k.Id);
            Property(p => p.Title).HasMaxLength(100).IsRequired();
            Property(p => p.Description).HasMaxLength(2000).IsRequired();
        }
    }
}
