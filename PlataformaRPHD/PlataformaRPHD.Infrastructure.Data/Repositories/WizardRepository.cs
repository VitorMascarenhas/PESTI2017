using System;
using System.Collections.Generic;
using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using System.Linq;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class WizardRepository : BaseRepository<Wizard, int>, IWizardRepository
    {
        public WizardRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Wizard> GetApprovedWizards()
        {
            return this.Find(x => x.Approved == true);
        }

        public IEnumerable<Wizard> GetNotApprovedWizards()
        {
            return this.Find(x => x.Approved == false);
        }

        public IEnumerable<Wizard> GetMyWizards(string samAccountName)
        {
            return this.Find(x => x.CreateBy.mechanographicNumber == samAccountName);
        }
    }
}
