using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class InteractionEntityConfiguration : EntityTypeConfiguration<Interaction>
    {
        public InteractionEntityConfiguration()
        {
            this.HasKey(k => k.Id);
        }
    }
}
