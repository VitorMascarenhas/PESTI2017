﻿using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PlataformaRPHD.Infrastructure.Data
{
    public class STICketContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="STICketContext"/> class.
        /// </summary>
        public STICketContext() : base("STICketConnectionString")
        {
            //Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ChangeTaskStatus> ChangesTaskStatus { get; set; }

        public DbSet<Impact> Impacts { get; set; }

        public DbSet<Interaction> Interactions { get; set; }

        public DbSet<Message> Messages { get; set; }
        
        public DbSet<Origin> Origins { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<Resolution> Resolutions { get; set; }

        public DbSet<SatisfactionSurvey> SatisfactionsSurveys { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Step> Steps { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Transfer> Transfers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Wizard> Wizards { get; set; }

        public static STICketContext Create()
        {
            return new STICketContext();
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
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new RequestEntityConfiguration());
            modelBuilder.Configurations.Add(new TaskEntityConfiguration());
            //modelBuilder.Configurations.Add(new PointOfInterestEntityConfiguration());
            //modelBuilder.Configurations.Add(new RoadEntityConfiguration());
            //modelBuilder.Configurations.Add(new UserAuditTrailEntityConfiguration());
            //modelBuilder.Configurations.Add(new GpsCoordinateEntityConfiguration());
            //modelBuilder.Configurations.Add(new RouteEntityTypeConfiguration());
        }
    }
}
