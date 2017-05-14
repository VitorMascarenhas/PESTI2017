using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class HistoryChangeTaskStatusRepository : BaseRepository<HistoryChangeTaskStatus>, IHistoryChangeTaskStatusRepository
    {
        public HistoryChangeTaskStatusRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
