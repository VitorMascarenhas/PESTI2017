using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class ServiceMap : ClassMap<Service>
    {
        public ServiceMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
