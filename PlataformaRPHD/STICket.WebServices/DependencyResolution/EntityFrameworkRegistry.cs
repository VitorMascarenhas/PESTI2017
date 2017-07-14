using PlataformaRPHD.Infrastructure.Data;
using StructureMap;
using System.Data.Entity;

namespace STICket.WebServices.DependencyResolution
{
    public class EntityFrameworkRegistry : Registry
    {
        public EntityFrameworkRegistry()
        {
            For<DbContext>().Use(() => new STICketContext());
        }
    }
}