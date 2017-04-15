using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class HistoryOfTransfersRepository : BaseRepository<HistoryOfTransfers, int>, IHistoryOfTransfersRepository
    {
        public HistoryOfTransfersRepository(DbContext context) : base(context)
        {
        }
    }
}
