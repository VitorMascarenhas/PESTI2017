using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class HistoryOfTransfersMap : ClassMap<HistoryOfTransfers>
    {
        public HistoryOfTransfersMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            HasMany(x => x.Transfers);
            References(x => x.Task);
        }
    }
}
