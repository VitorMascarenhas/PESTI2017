using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class ServiceEntityConfiguration : EntityTypeConfiguration<Service>
    {
        public ServiceEntityConfiguration()
        {
            this.HasKey(k => k.Id);
            Property(p => p.Name).HasMaxLength(100).IsRequired();
        }
    }
}
