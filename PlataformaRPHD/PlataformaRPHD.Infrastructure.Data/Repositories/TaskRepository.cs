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

        public Task GetTaskById(int taskId)
        {
            return this.Find(x => x.Id == taskId).SingleOrDefault();
        }

        public IEnumerable<Task> GetTaskByUser(string mechanographicNumber)
        {
            return this.Find(x => x.Owner.mechanographicNumber == mechanographicNumber);
        }

        public IEnumerable<Task> GetTaskByUserWithState(string mechanographicNumber, string taskStatus)
        {
            return this.Find(x => x.Owner.mechanographicNumber == mechanographicNumber && x.status.GetStatus() == taskStatus);
        }

        public IEnumerable<Task> GetTasksByState(string status)
        {
            return this.Find(x => x.status.GetStatus() == status);
        }
    }
}
