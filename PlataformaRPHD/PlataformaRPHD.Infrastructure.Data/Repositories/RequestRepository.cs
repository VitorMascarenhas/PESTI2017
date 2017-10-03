using System.Collections.Generic;
using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using System.Linq;
using System;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class RequestRepository : BaseRepository<Request, int>, IRequestRepository
    {
        public RequestRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Request> GetClosedRequests(string includeProperties)
        {
            return this.Find(x => x.Interactions.All(t => t.Task.close == true));
        }

        public IEnumerable<Request> GetPendingRequests(string includeProperties)
        {
            return this.Find(x => x.Interactions.Any(t => t.Task.status.GetStatus() == "Pendente"), null, includeProperties);
        }

        public IEnumerable<Request> GetOpenRequests(string includeProperties)
        {
            return this.Find(x => x.Interactions.Any(t => t.Task.status.GetStatus() == "Aberto"), null, includeProperties);
        }

        public Request GetRequestWithProperties(int requestId, string includeProperties = "")
        {
            return this.Find(x => x.Id == requestId, null, includeProperties).SingleOrDefault();
        }
    }
}
