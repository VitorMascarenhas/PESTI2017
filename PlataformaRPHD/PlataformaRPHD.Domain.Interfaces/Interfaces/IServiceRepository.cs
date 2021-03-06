﻿using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface IServiceRepository : IBaseRepository<Service, int>
    {
        Service GetService(int id);
    }
}
