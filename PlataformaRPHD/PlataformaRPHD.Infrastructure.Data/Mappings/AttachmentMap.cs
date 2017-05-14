using PlataformaRPHD.Domain.Entities.Entities;
using FluentNHibernate.Mapping;

namespace PlataformaRPHD.Infrastructure.Data.Mappings
{
    public class AttachmentMap : ClassMap<Attachment>
    {
        public AttachmentMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            References(x => x.Interaction);
        }
    }
}
