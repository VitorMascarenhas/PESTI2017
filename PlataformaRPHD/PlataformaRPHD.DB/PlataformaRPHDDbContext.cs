using Microsoft.AspNet.Identity.EntityFramework;
using PlataformaRPHD.DB.Configuration;
using PlataformaRPHD.DB.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PlataformaRPHD.DB
{
    /// <summary>
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class PlataformaRPHDDbContext : IdentityDbContext
    {
        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<HistoryMessage> HistoryMessages { get; set; }

        public DbSet<HistoryOfTransfers> HistoryOfTransfers { get; set; }

        public DbSet<Interaction> Interactions { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<Resolution> Resolutions { get; set; }

        public DbSet<SatisfactionSurvey> SatisfactionSurveys { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Domain.Task> Tasks { get; set; }

        public DbSet<ITaskStatus> TaskStatus { get; set; }

        public DbSet<Topic> Topics { get; set; }
        
        public DbSet<User> users { get; set; }

        public DbSet<UserStatus> UsersStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlataformaRPHDDbContext"/> class.
        /// </summary>
        public PlataformaRPHDDbContext() : base("PlataformaRPHDConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<PlataformaRPHDDbContext>(new UniDBInitializer<PlataformaRPHDDbContext>());
        }

        private class UniDBInitializer<T> : DropCreateDatabaseAlways<PlataformaRPHDDbContext>
        {
            protected override void Seed(PlataformaRPHDDbContext context)
            {
                IList<Category> categories = new List<Category>();

                categories.Add(new Category("Aplicacional", "Aplicações informáticas")
                {
                });

                categories.Add(new Category("Equipamento informático", "Equipamento informático")
                {
                });

                categories.Add(new Category("Rede/internet", "Rede/internet")
                {
                });

                categories.Add(new Category("Sistemas", "Sistemas")
                {
                });

                categories.Add(new Category("Pedidos de logins", "Pedidos de logins")
                {
                });

                categories.Add(new Category("Erros/falhas aplicacionais", "Erros/falhas aplicacionais")
                {
                });

                categories.Add(new Category("HP-HCIS", "HP-HCIS")
                {
                });

                categories.Add(new Category("SINUS", "SINUS")
                {
                });

                categories.Add(new Category("Sclinico hospitalar", "Sclinico hospitalar")
                {
                });

                categories.Add(new Category("Sclinico CSP", "Sclinico CSP")
                {
                });

                categories.Add(new Category("SIIMA", "SIIMA")
                {
                });

                categories.Add(new Category("SONHO", "SONHO")
                {
                });

                categories.Add(new Category("Avaria de equipamento", "Avaria de equipamento")
                {
                });

                categories.Add(new Category("Desaparecimento de equipamento", "Desaparecimento de equipamento")
                {
                });

                categories.Add(new Category("Substituição de equipamento", "Substituição de equipamento")
                {
                });

                categories.Add(new Category("Rato", "Rato")
                {
                });

                categories.Add(new Category("Teclado", "Teclado")
                {
                });

                categories.Add(new Category("Monitor", "Monitor")
                {
                });

                categories.Add(new Category("Leitor de cartões", "Leitor de cartões")
                {
                });

                categories.Add(new Category("acesso à rede", "acesso à rede")
                {
                });

                categories.Add(new Category("Criação/acesso a pastas partilhadas", "Criação/acesso a pastas partilhadas")
                {
                });

                categories.Add(new Category("E-mail", "E-mail")
                {
                });

                categories.Add(new Category("Internet", "Internet")
                {
                });

                IList<Topic> topics = new List<Topic>();

                topics.Add(new Topic(1, 5)
                {
                });

                topics.Add(new Topic(1, 6)
                {
                });

                topics.Add(new Topic(5, 7)
                {
                });

                topics.Add(new Topic(5, 8)
                {
                });

                topics.Add(new Topic(5, 9)
                {
                });

                topics.Add(new Topic(5, 10)
                {
                });

                topics.Add(new Topic(5, 11)
                {
                });

                topics.Add(new Topic(5, 12)
                {
                });

                topics.Add(new Topic(6, 7)
                {
                });

                topics.Add(new Topic(6, 8)
                {
                });

                topics.Add(new Topic(6, 9)
                {
                });

                topics.Add(new Topic(6, 10)
                {
                });

                topics.Add(new Topic(2, 13)
                {
                });

                topics.Add(new Topic(2, 14)
                {
                });

                topics.Add(new Topic(2, 15)
                {
                });

                topics.Add(new Topic(13, 16)
                {
                });

                topics.Add(new Topic(13, 17)
                {
                });

                topics.Add(new Topic(13, 18)
                {
                });

                topics.Add(new Topic(13, 19)
                {
                });







                topics.Add(new Topic(6, 11)
                {
                });

                topics.Add(new Topic(6, 12)
                {
                });

                topics.Add(new Topic(13, 16)
                {
                });

                topics.Add(new Topic(13, 17)
                {
                });

                topics.Add(new Topic(13, 18)
                {
                });

                topics.Add(new Topic(13, 19)
                {
                });

                topics.Add(new Topic(14, 16)
                {
                });

                topics.Add(new Topic(14, 17)
                {
                });

                topics.Add(new Topic(14, 18)
                {
                });

                topics.Add(new Topic(14, 19)
                {
                });

                topics.Add(new Topic(15, 16)
                {
                });

                topics.Add(new Topic(15, 17)
                {
                });

                topics.Add(new Topic(15, 18)
                {
                });

                topics.Add(new Topic(15, 19)
                {
                });

                topics.Add(new Topic(3, 20)
                {
                });

                topics.Add(new Topic(3, 21)
                {
                });

                topics.Add(new Topic(3, 22)
                {
                });

                topics.Add(new Topic(3, 23)
                {
                });

                foreach (Topic topic in topics)
                    context.Topics.Add(topic);

                foreach (Category category in categories)
                    context.Categories.Add(category);
                base.Seed(context);
            }
        }

        public static PlataformaRPHDDbContext Create()
        {
            return new PlataformaRPHDDbContext();
        }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.
        /// </remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // inicialização do Identity

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CategoryEntityConfiguration());
            modelBuilder.Configurations.Add(new HistoryMessageEntityConfiguration());
            modelBuilder.Configurations.Add(new HistoryOfTransfersEntityConfiguration());
            modelBuilder.Configurations.Add(new InteractionEntityConfiguration());
            modelBuilder.Configurations.Add(new MessageEntityConfiguration());
            modelBuilder.Configurations.Add(new RequestEntityConfiguration());
            modelBuilder.Configurations.Add(new ResolutionEntityConfiguration());
            modelBuilder.Configurations.Add(new SatisfactionSurveyEntityConfiguration());
            modelBuilder.Configurations.Add(new ServiceEntityConfiguration());
            modelBuilder.Configurations.Add(new TaskEntityConfiguration());
            modelBuilder.Configurations.Add(new ITaskStatusEntityConfiguration());
            modelBuilder.Configurations.Add(new TopicEntityConfiguration());
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new UserStatusEntityConfiguration());
        }
    }
}
