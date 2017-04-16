using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class MessageEntityConfiguration : EntityTypeConfiguration<Message>
    {
        public MessageEntityConfiguration()
        {
            this.HasKey(k => k.Id);
            Property(p => p.text).HasMaxLength(200).IsRequired();
        }
    }
}
