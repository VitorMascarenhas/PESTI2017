using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class RequestRepository : BaseRepository<Request, int>, IRequestRepository
    {
        public RequestRepository(DbContext context) : base(context)
        {
        }
    }
}
