using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class ServiceRepository : BaseRepository<Service>, IServiceRepository
    {
        public ServiceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
