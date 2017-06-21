using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class ChangeTaskStatusRepository : BaseRepository<ChangeTaskStatus, int>, IChangeTaskStatus
    {
        public ChangeTaskStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
