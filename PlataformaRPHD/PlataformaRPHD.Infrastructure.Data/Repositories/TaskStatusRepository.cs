using PlataformaRPHD.Domain.Interfaces.Interfaces;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class TaskStatusRepository : BaseRepository<ITaskStatus>, ITaskStatusRepository
    {
        public TaskStatusRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
