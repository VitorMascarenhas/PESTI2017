using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface IInteractionRepository : IBaseRepository<Interaction, int>
    {
        Interaction GetInteractionWithProperties(int interactionId, string includeProperties = "");

        Interaction GetInteractionByTaskId(int taskId, string includeProperties = "");

        IEnumerable<Interaction> GetInteractionsByTaskStatus(string status, string includeProperties = "");
    }
}
