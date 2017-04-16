using Microsoft.AspNet.Identity.EntityFramework;
using PlataformaRPHD.DB.Configuration;
using PlataformaRPHD.DB.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Threading.Tasks;

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

        public DbSet<Domain.TaskStatus> TaskStatus { get; set; }

        public DbSet<Topic> Topics { get; set; }
        
        public DbSet<User> users { get; set; }

        public DbSet<UserStatus> UsersStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlataformaRPHDDbContext"/> class.
        /// </summary>
        public PlataformaRPHDDbContext() : base("PlataformaRPHDConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
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
            modelBuilder.Configurations.Add(new TaskStatusEntityConfiguration());
            modelBuilder.Configurations.Add(new TopicEntityConfiguration());
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new UserStatusEntityConfiguration());
        }
    }
}
