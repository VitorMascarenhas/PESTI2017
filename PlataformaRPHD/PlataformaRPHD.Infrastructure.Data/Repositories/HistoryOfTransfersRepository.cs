using NHibernate;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class HistoryOfTransfersRepository : BaseRepository<HistoryOfTransfers>, IHistoryOfTransfersRepository
    {
        public HistoryOfTransfersRepository(ISession session) : base(session)
        {
        }
    }
}
