using System.Data.Entity;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using PlataformaRPHD.Domain.Entities.Entities;
using System;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class OriginRepository : BaseRepository<Origin, int>, IOriginRepository
    {
        public OriginRepository(DbContext context) : base(context)
        {
        }

        public Origin GetOriginByName(string name)
        {
            return this.FirstOrDefault(x => x.Name == name);
        }
    }
}
