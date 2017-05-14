using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class TransferRepository : BaseRepository<Transfer>, ITransferRepository
    {
        public TransferRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
