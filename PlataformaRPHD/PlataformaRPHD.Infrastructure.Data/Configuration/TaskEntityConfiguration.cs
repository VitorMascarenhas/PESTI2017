using PlataformaRPHD.Domain.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.Infrastructure.Data.Configuration
{
    public class TaskEntityConfiguration : EntityTypeConfiguration<Task>
    {
        public TaskEntityConfiguration()
        {
            HasKey(k => k.Id);
        }
    }
}
