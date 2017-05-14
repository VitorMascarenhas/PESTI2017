using FluentNHibernate.Mapping;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class TransferMap : ClassMap<Transfer>
    {
        public TransferMap()
        {
            Id(x => x.Id);
            References(x => x.OfUser);
            References(x => x.FromUser);
            References(x => x.WhoTransferred);
            Map(x => x.description).Length(500).Not.Nullable();
        }
    }
}
