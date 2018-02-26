using System.Data.Entity;
using System.Linq;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public User GetUserBySamAccountName(string samAccountName)
        {
            return this.FirstOrDefault(x => x.mechanographicNumber == samAccountName);
        }
    }
}
