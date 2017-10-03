using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using System.Linq;
using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class TaskRepository : BaseRepository<Task, int>, ITaskRepository
    {
        public TaskRepository(DbContext context) : base(context)
        {
        }
    }
}
