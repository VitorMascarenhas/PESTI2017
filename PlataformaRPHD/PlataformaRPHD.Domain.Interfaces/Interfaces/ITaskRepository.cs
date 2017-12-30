using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface ITaskRepository : IBaseRepository<Task, int>
    {
        // Returns a list of tasks of a user
        IEnumerable<Task> GetTaskByUser(string mechanographicNumber);

        // returns a list of tasks of a user with a specific state
        IEnumerable<Task> GetTaskByUserWithState(string mechanographicNumber, string taskStatus);

        // returns a list of tasks for specific state
        IEnumerable<Task> GetTasksByState(string status);

        // find task by id
        Task GetTaskById(int taskId);
    }
}
