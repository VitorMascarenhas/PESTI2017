using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class HistoryMessageMap : ClassMap<HistoryMessage>
    {
        public HistoryMessageMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            HasMany(x => x.Messages);
        }
    }
}
