using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class SatisfactionSurveyMap : ClassMap<SatisfactionSurvey>
    {
        public SatisfactionSurveyMap()
        {
            Id(x => x.Id);
            References(x => x.Request);
        }
    }
}
