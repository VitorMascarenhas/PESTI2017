using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class UserStatusMap : ClassMap<UserStatus>
    {
        public UserStatusMap()
        {
            Id(x => x.Id);
            Map(x => x.Status);
        }
    }
}
