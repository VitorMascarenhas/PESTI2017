using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class MessageMap : ClassMap<Message>
    {
        public MessageMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.text).Length(500).Not.Nullable();
            References(x => x.HistoryMessage);
            Map(x => x.CreationTime);
        }
    }
}
