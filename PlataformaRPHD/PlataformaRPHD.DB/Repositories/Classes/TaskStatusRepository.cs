using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class TaskStatusRepository : BaseRepository<TaskStatus, int>, ITaskStatusRepository
    {
        public TaskStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
