using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class TaskStatusEntityConfiguration : EntityTypeConfiguration<TaskStatus>
    {
        public TaskStatusEntityConfiguration()
        {
            this.HasKey(k => k.Id);
            Property(p => p.Status).HasMaxLength(100).IsRequired();
        }
    }
}
