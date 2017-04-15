using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class TaskRepository : BaseRepository<Task, int>, ITaskRepository
    {
        public TaskRepository(DbContext context) : base(context)
        {
        }
    }
}
