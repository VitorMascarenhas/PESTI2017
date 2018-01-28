using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface IResolutionRepository : IBaseRepository<Resolution, int>
    {
        //retorna todas as resoluções
        IEnumerable<Resolution> GetAllResolutions();

        //return a resolutions of a user
        IEnumerable<Resolution> GetMyResolutions(string mechanographicNumber);
    }
}
