using PlataformaRPHD.Domain.Interfaces.Interfaces;
using PlataformaRPHD.Domain.Entities.Entities;
using NHibernate;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class TaskStatusRepository : BaseRepository<ITaskStatus>, ITaskStatusRepository
    {
        public TaskStatusRepository(ISession session) : base(session)
        {
        }
    }
}
