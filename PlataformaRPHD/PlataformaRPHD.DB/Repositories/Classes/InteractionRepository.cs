using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class InteractionRepository : BaseRepository<Interaction, int>, IInteractionRepository
    {
        public InteractionRepository(DbContext context) : base(context)
        {
        }
    }
}
