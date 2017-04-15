using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class MessageRepository : BaseRepository<Message, int>, IMessageRepository
    {
        public MessageRepository(DbContext context) : base(context)
        {
        }
    }
}
