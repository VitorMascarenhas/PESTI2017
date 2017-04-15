using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class HistoryMessageRepository : BaseRepository<HistoryMessage, int>, IHistoryMessageRepository
    {
        public HistoryMessageRepository(DbContext context) : base(context)
        {
        }
    }
}
