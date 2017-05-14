﻿using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class HistoryMessageRepository : BaseRepository<HistoryMessage>, IHistoryMessageRepository
    {
        public HistoryMessageRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
