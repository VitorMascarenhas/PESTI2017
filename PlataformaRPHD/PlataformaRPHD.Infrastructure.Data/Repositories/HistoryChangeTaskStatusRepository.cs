using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class HistoryChangeTaskStatusRepository : BaseRepository<HistoryChangeTaskStatus, int>, IHistoryChangeTaskStatusRepository
    {
        public HistoryChangeTaskStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
