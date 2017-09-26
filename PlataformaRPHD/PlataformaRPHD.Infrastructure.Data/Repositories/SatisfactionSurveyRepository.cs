using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class SatisfactionSurveyRepository : BaseRepository<SatisfactionSurvey, int>, ISatisfactionSurveyRepository
    {
        public SatisfactionSurveyRepository(DbContext context) : base(context)
        {
        }
    }
}
