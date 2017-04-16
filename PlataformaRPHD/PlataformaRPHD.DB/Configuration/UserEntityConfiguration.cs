using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class UserEntityConfiguration : EntityTypeConfiguration<User>
    {
        public UserEntityConfiguration()
        {
            this.HasKey(k => k.Id);
            Property(first => first.Name.FirstName).IsRequired();
            Property(last => last.Name.LastName).IsRequired();
            Property(m => m.mechanographicNumber).IsRequired();
        }
    }
}
