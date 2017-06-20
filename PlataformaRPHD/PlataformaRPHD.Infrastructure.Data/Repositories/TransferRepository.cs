using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class TransferRepository : BaseRepository<Transfer, int>, ITransferRepository
    {
        public TransferRepository(DbContext context) : base(context)
        {
        }
    }
}
