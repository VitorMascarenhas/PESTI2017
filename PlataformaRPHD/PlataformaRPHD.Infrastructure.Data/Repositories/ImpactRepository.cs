using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class ImpactRepository : BaseRepository<Impact, int>, IImpactRepository
    {
        public ImpactRepository(DbContext context) : base(context)
        {
        }
    }
}
