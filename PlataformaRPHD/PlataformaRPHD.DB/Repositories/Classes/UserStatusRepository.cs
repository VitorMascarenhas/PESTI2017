using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class UserStatusRepository : BaseRepository<UserStatus, int>, IUserStatusRepository
    {
        public UserStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
