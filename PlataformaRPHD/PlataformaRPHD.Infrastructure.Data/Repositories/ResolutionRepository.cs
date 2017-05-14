using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class ResolutionRepository : BaseRepository<Resolution>, IResolutionRepository
    {
        public ResolutionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
