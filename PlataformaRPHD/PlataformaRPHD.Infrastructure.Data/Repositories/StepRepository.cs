using System.Data.Entity;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class StepRepository : BaseRepository<Step, int>, IStepRepository
    {
        public StepRepository(DbContext context) : base(context)
        {
        }
    }
}
