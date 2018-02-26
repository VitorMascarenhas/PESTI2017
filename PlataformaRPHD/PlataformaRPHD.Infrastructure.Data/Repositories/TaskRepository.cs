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
            return this.Find(x => x.Owner.mechanographicNumber == mechanographicNumber && x.Status == taskStatus);
        }

        public IEnumerable<Task> GetTasksByState(string status)
        {
            return this.Find(x => x.Status == status);
        }

        public IEnumerable<Task> GetOpenStatus(string user)
        {
            return this.Find(x => x.Owner.mechanographicNumber == user && x.Status == "Aberto");
        }

        public IEnumerable<Task> GetCloseStatus(string user)
        {
            return this.Find(x => x.Owner.mechanographicNumber == user && x.Status == "Fechado");
        }

        public IEnumerable<Task> GetPendingStatus(string user)
        {
            return this.Find(x => x.Owner.mechanographicNumber == user && x.Status == "Pendente");
        }

        public IEnumerable<Task> GetTasksWithoutUser()
        {
            return this.Find(x => x.Owner == null);
        }
    }
}
