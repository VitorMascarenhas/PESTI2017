﻿using PlataformaRPHD.Domain.Entities.Entities;
using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface IRequestRepository : IBaseRepository<Request, int>
    {
        // get request by Id
        Request GetRequestByUserWithProperties(int requestId, string includeProperties = "");

        // get all requests by status
        IEnumerable<Request> GetRequestsByStatus(string includeProperties, string status);

        // get requests by user with status
        IEnumerable<Request> GetRequestsByUserWithStatus(string includeProperties, string mechanographicNumber, string status);

        // get all open requests
        IEnumerable<Request> GetOpenRequests(string includeProperties = "");

        // get all open requests by user
        IEnumerable<Request> GetOpenRequestsByUser(string includeProperties, string mechanographicNumber);

        IEnumerable<Request> SearchRquestById(int id, DateTime fromData, DateTime toData, string title, string description, string samAccountName);

        IEnumerable<Request>  SearchAllRquestsById(int id, DateTime fromData, DateTime toData, string title, string description);

        IEnumerable<Request> GetClosedRequestsWithoutSatisfactionSurvey(string user, string includeProperties = "");
    }
}
