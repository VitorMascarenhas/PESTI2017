using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class HistoryChangeTaskStatusRepository : BaseRepository<HistoryChangeTaskStatus, int>, IHistoryChangeTaskStatusRepository
    {
        public HistoryChangeTaskStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
