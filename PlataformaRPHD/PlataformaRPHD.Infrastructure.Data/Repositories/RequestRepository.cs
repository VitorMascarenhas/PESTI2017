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

        // get all requests by status
        public IEnumerable<Request> GetRequestsByStatus(string includeProperties, string status)
        {
            return this.Find(x => x.Interactions.Any(t => t.Task.Status == status), null, includeProperties);
        }

        // get requests by user with status
        public IEnumerable<Request> GetRequestsByUserWithStatus(string includeProperties, string mechanographicNumber, string status)
        {
            return this.Find(x => x.Interactions.Any(t => t.Task.Status == status && x.Owner.mechanographicNumber == mechanographicNumber) , null, includeProperties);
        }

        // get all open requests
        public IEnumerable<Request> GetOpenRequests(string includeProperties)
        {
            return this.Find(x => x.Interactions.Any(t => t.Task.Status == "Aberto"), null, includeProperties);
        }

        // get all open requests by user
        public IEnumerable<Request> GetOpenRequestsByUser(string includeProperties, string mechanographicNumber)
        {
            return this.Find(x => x.Interactions.Any(t => t.Task.Status == "Aberto" && x.Owner.mechanographicNumber == mechanographicNumber), null, includeProperties);
        }

        // get request by Id
        public Request GetRequestByUserWithProperties(int requestId, string includeProperties = "")
        {
            return this.Find(x => x.Id == requestId, null, includeProperties).SingleOrDefault();
        }
    }
}
