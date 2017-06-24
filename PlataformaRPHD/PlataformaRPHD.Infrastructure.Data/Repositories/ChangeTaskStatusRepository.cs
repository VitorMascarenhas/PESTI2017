using System.Data.Entity;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class ChangeTaskStatusRepository : BaseRepository<ChangeTaskStatus, int>, IChangeTaskStatusRepository
    {
        public ChangeTaskStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
