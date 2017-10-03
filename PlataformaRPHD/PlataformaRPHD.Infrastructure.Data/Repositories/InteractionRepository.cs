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

        public IEnumerable<Interaction> GetInteractionsByTaskStatus(string status, string includeProperties = "")
        {
            return this.Find(x => x.Task.status.GetStatus() == status, null, includeProperties);
        }

        public Interaction GetInteractionWithProperties(int interactionId, string includeProperties = "")
        {
            return this.Find(x => x.Id == interactionId, null, includeProperties).SingleOrDefault();
        }
    }
}
