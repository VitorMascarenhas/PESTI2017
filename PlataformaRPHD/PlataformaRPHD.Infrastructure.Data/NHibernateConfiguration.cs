using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using StructureMap;

namespace PlataformaRPHD.Infrastructure.Data
{
    public static class NHibernateConfiguration
    {


/*        public NHibernateRegistry()
        {
            For().Singleton().Use(GetSessionFactory());
            For().HybridHttpOrThreadLocalScoped().Use(x => x.GetInstance().OpenSession());
        }

        private static ISessionFactory GetSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                MsSqlConfiguration.MsSql2014.ConnectionString(
                    @"Data Source=.\SQLEXPRESS;Initial Catalog=STICketDB;Persist Security Info=True;User ID=sa;Password=123456")
                    //habilita a exibição dos SQL disparados contra o banco de dados no output do VS
                    .ShowSql())
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf())
                .ExposeConfiguration(c => new SchemaExport(c).Create(false, true))
                .BuildSessionFactory();
        }*/
    }
}
