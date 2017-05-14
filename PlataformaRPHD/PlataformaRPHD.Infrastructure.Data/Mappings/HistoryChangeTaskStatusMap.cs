using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class HistoryChangeTaskStatusMap : ClassMap<HistoryChangeTaskStatus>
    {
        public HistoryChangeTaskStatusMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            HasMany(x => x.History);
            References(x => x.Task);
        }
    }
}
