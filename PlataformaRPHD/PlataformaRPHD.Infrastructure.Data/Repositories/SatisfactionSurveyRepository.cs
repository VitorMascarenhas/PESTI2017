using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class SatisfactionSurveyRepository : BaseRepository<SatisfactionSurvey>, ISatisfactionSurveyRepository
    {
        public SatisfactionSurveyRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
