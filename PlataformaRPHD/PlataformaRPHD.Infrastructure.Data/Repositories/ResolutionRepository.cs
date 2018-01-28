using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class ResolutionRepository : BaseRepository<Resolution, int>, IResolutionRepository
    {
        public ResolutionRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Resolution> GetAllResolutions()
        {
            return this.GetAll();
        }

        public IEnumerable<Resolution> GetMyResolutions(string mechanographicNumber)
        {
            return this.Find(x => x.Tasks.First().Owner.mechanographicNumber == mechanographicNumber);
        }
    }
}
