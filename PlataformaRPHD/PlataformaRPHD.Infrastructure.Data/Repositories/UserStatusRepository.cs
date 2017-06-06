using PlataformaRPHD.Domain.Interfaces.Interfaces;
using PlataformaRPHD.Domain.Entities.Entities;
using NHibernate;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class UserStatusRepository : BaseRepository<UserStatus>, IUserStatusRepository
    {
        public UserStatusRepository(ISession session) : base(session)
        {
        }
    }
}
