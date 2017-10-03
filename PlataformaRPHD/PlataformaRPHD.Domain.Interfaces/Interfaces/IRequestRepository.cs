using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface IRequestRepository : IBaseRepository<Request, int>
    {
        Request GetRequestWithProperties(int requestId, string includeProperties);

        IEnumerable<Request> GetClosedRequests(string includeProperties);

        IEnumerable<Request> GetPendingRequests(string includeProperties);

        IEnumerable<Request> GetOpenRequests(string includeProperties);
    }
}
