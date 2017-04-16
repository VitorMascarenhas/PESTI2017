using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class ResolutionEntityConfiguration : EntityTypeConfiguration<Resolution>
    {
        public ResolutionEntityConfiguration()
        {
            this.HasKey(k => k.Id);
            Property(p => p.resolutionText).HasMaxLength(1500).IsRequired();
        }
    }
}
