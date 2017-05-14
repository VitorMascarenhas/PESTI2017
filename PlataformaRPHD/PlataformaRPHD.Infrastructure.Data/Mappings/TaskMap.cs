using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class TaskMap : ClassMap<Task>
    {
        public TaskMap()
        {
            Id(x => x.Id);
            References(x => x.Owner);
            Map(x => x.status);
            References(x => x.Interaction);
            References(x => x.resolution);
            Map(x => x.close);

        }
    }
}
