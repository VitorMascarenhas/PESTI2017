using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface IWizardRepository : IBaseRepository<Wizard, int>
    {
        IEnumerable<Wizard> GetApprovedWizards();

        IEnumerable<Wizard> GetNotApprovedWizards();

        IEnumerable<Wizard> GetMyWizards(string samAccountName);
    }
}
