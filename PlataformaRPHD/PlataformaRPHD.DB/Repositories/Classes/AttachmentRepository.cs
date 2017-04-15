using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class AttachmentRepository : BaseRepository<Attachment, int>, IAttachmentRepository
    {
        public AttachmentRepository(DbContext context) : base(context)
        {
        }
    }
}
