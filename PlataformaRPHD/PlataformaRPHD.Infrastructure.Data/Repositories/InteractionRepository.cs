using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class InteractionRepository : BaseRepository<Interaction, int>, IInteractionRepository
    {
        public InteractionRepository(DbContext context) : base(context)
        {
        }
    }
}
