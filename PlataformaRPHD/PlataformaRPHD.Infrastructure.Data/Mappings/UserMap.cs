using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.Name.FirstName).Length(50).Not.Nullable();
            Map(x => x.Name.LastName).Length(50).Not.Nullable();
            Map(x => x.mechanographicNumber).Length(20).Not.Nullable();
            Map(x => x.mail).Length(50).Not.Nullable();
            Map(x => x.phoneNumber).Length(20);
            HasMany(x => x.Requests);
            HasMany(x => x.Tasks);
            Map(x => x.userStatus);
        }
    }
}
