using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class AttachmentRepository : BaseRepository<Attachment, int>, IAttachmentRepository
    {
        public AttachmentRepository(DbContext context) : base(context)
        {
        }
    }
}
