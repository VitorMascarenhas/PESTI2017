using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class ResolutionRepository : BaseRepository<Resolution, int>, IResolutionRepository
    {
        public ResolutionRepository(DbContext context) : base(context)
        {
        }
    }
}
