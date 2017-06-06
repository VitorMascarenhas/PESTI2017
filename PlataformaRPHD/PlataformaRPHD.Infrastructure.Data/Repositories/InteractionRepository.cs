using NHibernate;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class InteractionRepository : BaseRepository<Interaction>, IInteractionRepository
    {
        public InteractionRepository(ISession session) : base(session)
        {
        }
    }
}
