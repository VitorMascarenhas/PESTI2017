using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class TaskStatusMap : ClassMap<ITaskStatus>
    {
        public TaskStatusMap()
        {
            Id(x => x.Id);

        }
    }
}
