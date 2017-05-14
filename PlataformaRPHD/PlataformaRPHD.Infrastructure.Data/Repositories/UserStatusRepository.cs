using PlataformaRPHD.Domain.Interfaces.Interfaces;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class UserStatusRepository : BaseRepository<UserStatus>, IUserStatusRepository
    {
        public UserStatusRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
