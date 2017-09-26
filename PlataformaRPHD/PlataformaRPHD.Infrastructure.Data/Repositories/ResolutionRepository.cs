using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class ResolutionRepository : BaseRepository<Resolution, int>, IResolutionRepository
    {
        public ResolutionRepository(DbContext context) : base(context)
        {
        }
    }
}
