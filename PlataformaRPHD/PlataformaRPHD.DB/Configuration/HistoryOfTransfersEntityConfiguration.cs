using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class HistoryOfTransfersEntityConfiguration : EntityTypeConfiguration<HistoryOfTransfers>
    {
        public HistoryOfTransfersEntityConfiguration()
        {
            this.HasKey(k => k.Id);
            Property(p => p.description).HasMaxLength(200).IsRequired();
        }
    }
}
