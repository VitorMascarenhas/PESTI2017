﻿using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class TransferRepository : BaseRepository<Transfer, int>, ITransferRepository
    {
        public TransferRepository(DbContext context) : base(context)
        {
        }
    }
}