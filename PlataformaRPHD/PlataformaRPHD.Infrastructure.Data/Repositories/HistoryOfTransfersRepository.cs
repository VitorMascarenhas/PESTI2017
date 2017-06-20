using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class HistoryOfTransfersRepository : BaseRepository<HistoryOfTransfers, int>, IHistoryOfTransfersRepository
    {
        public HistoryOfTransfersRepository(DbContext context) : base(context)
        {
        }
    }
}
