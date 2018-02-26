using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using System.Linq;
using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class InteractionRepository : BaseRepository<Interaction, int>, IInteractionRepository
    {
        public InteractionRepository(DbContext context) : base(context)
        {
        }

        public Interaction GetInteractionByTaskId(int taskId, string includeProperties = "")
        {
            return this.Find(i => i.Task.Id == taskId, null, includeProperties).SingleOrDefault();
        }

        public IEnumerable<Interaction> GetInteractionsByOpenTaskStatus(string user, string includeProperties = "")
        {
            return this.Find(x => x.Task.Status == "Aberto" && x.Task.Owner.mechanographicNumber == user, null, includeProperties);
        }

        // interactions by open status
        public Interaction GetInteractionWithProperties(int interactionId, string includeProperties = "")
        {
            return this.Find(x => x.Id == interactionId, null, includeProperties).SingleOrDefault();
        }

        // interactions by close status
        public IEnumerable<Interaction> GetInteractionsByCloseTaskStatus(string user, string includeProperties = "")
        {
            return this.Find(x => x.Task.Status == "Fechado" && x.Task.Owner.mechanographicNumber == user, null, includeProperties);
        }

        // interactions by close status
        public IEnumerable<Interaction> GetInteractionsByPendingTaskStatus(string user, string includeProperties = "")
        {
            return this.Find(x => x.Task.Status == "Pendente" && x.Task.Owner.mechanographicNumber == user, null, includeProperties);
        }
        
        public IEnumerable<Interaction> GetInteractionsByTaskWithoutUser(string includeProperties = "")
        {
            return this.Find(x => x.Task.Owner == null, null, includeProperties);
        }

        public Interaction GetInteractionById(int id, string includeProperties = "")
        {
            return this.Find(x => x.Id == id, null, includeProperties).FirstOrDefault();
        }
    }
}
