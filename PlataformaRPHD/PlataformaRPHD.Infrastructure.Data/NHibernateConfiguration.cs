using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Mappings;

namespace PlataformaRPHD.Infrastructure.Data
{
    public class NHibernateConfiguration
    {
        //private ISessionFactory session;

        private static ISessionFactory factory;

        private NHibernateConfiguration() 
        {
            //var factory = Fluently.Configure()
            //.Mappings(m =>
            //    {
            //        m.FluentMappings.AddFromAssemblyOf<AttachmentMap>();
            //        m.FluentMappings.AddFromAssemblyOf<CategoryMap>();
            //    })
            //.BuildSessionFactory();
        }

        public static ISessionFactory Instance
        {
            get
            {
                //TODO: Tratar de colocar as configurações mais bonitas
                if (factory == null)
                {
                    var cfg = new StoreConfiguration();
                    factory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(@"Server=.\sqlexpress;Database=STicket;User Id=STICket; Password=123456;")
                    .ShowSql())
                    .Mappings(m =>
                    m.AutoMappings.Add(AutoMap.AssemblyOf<Category>(cfg)))
                    .BuildSessionFactory();
                }
                return factory;
            }
        }

        //public static ISessionFactory GetSession()
        //{
        //    if(session == null)
        //    {
        //        this.NHibernateConfiguration();
        //    }
        //    else
        //    {
        //        return session;
        //    }
        //}


        /*public NHibernateRegistry()
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
