using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class TopicRepository : BaseRepository<Topic, int>, ITopicRepository
    {
        public TopicRepository(DbContext context) : base(context)
        {
        }
    }
}
