using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class HistoryMessageRepository : BaseRepository<HistoryMessage, int>, IHistoryMessageRepository
    {
        public HistoryMessageRepository(DbContext context) : base(context)
        {
        }
    }
}
