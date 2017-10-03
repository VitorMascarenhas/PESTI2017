using PlataformaRPHD.Domain.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.Infrastructure.Data.Configuration
{
    public class RequestEntityConfiguration : EntityTypeConfiguration<Request>
    {
        public RequestEntityConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.Title).HasMaxLength(200);
            Property(p => p.Description).HasMaxLength(2500);
            Property(p => p.Contact).HasMaxLength(100);
            Property(p => p.SourceComputer).HasMaxLength(50);
        }
    }
}
