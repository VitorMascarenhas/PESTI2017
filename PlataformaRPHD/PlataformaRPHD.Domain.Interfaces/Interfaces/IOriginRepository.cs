using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface IOriginRepository : IBaseRepository<Origin, int>
    {
        Origin GetOriginByName(string name);
    }
}
