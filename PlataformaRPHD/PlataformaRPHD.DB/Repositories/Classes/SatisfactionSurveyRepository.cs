using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Interfaces;
using System.Data.Entity;

namespace PlataformaRPHD.DB.Repositories.Classes
{
    public class SatisfactionSurveyRepository : BaseRepository<SatisfactionSurvey, int>, ISatisfactionSurveyRepository
    {
        public SatisfactionSurveyRepository(DbContext context) : base(context)
        {
        }
    }
}
