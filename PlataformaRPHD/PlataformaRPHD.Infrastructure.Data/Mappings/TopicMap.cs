using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class TopicMap : ClassMap<Topic>
    {
        public TopicMap()
        {
            Id(x => x.Id);
            References(x => x.UpCategory);
            References(x => x.DownCategory);
        }
    }
}
