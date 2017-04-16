using PlataformaRPHD.DB.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PlataformaRPHD.DB.Configuration
{
    public class SatisfactionSurveyEntityConfiguration : EntityTypeConfiguration<SatisfactionSurvey>
    {
        public SatisfactionSurveyEntityConfiguration()
        {
            this.HasKey(k => k.Id);
        }
    }
}
