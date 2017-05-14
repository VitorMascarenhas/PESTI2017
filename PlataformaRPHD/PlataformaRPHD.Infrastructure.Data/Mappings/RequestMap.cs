using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class RequestMap : ClassMap<Request>
    {
        public RequestMap()
        {
            Id(x => x.Id);
            References(x => x.WhoRegistered);
            References(x => x.Owner);
            Map(x => x.TimeOfRegistration);
            Map(x => x.Title).Length(150).Not.Nullable();
            Map(x => x.Description).Length(1000).Not.Nullable();
            HasMany(x => x.Interactions);
            Map(x => x.sourceComputer).Length(15).Not.Nullable();
        }
    }
}
