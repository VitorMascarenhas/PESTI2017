using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class ResolutionMap : ClassMap<Resolution>
    {
        public ResolutionMap()
        {
            Id(x => x.Id);
            Map(x => x.resolutionText).Length(500).Not.Nullable();
            HasMany(x => x.Tasks);

        }
    }
}
