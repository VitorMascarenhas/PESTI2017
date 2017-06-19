using NHibernate;
using PlataformaRPHD.Infrastructure.Data;
using StructureMap;

namespace PlataformaRPHD.Web.DependencyResolution
{
    public class NHibernateRegistry : Registry
    {
        public NHibernateRegistry()
        {
            For<ISessionFactory>().Use(NHibernateConfiguration.Instance);
        }
    }
}