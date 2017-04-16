using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class HistoryMessageEntityConfiguration : EntityTypeConfiguration<HistoryMessage>
    {
        public HistoryMessageEntityConfiguration()
        {
            this.HasKey(k => k.Id);
        }
    }
}
