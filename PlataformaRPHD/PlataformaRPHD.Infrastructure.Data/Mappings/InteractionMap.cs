using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class InteractionMap : ClassMap<Interaction>
    {
        public InteractionMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.service);
            Map(x => x.Topic);
            References(x => x.HistoryMessage);
            HasMany(x => x.attachments).Cascade.All();
            References(x => x.Request);
        }
    }
}
