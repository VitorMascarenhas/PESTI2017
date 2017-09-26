using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class TaskStatusRepository : BaseRepository<TaskStatus, int>, ITaskStatusRepository
    {
        public TaskStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
