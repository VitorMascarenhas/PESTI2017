using NHibernate;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using System.Configuration;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISession _session; // adicionado
        
        private readonly ISessionFactory _sessionFactory;
        private ITransaction _transaction;

        //public ISession Session { get; set; }
        
        //static UnitOfWork()
        //{
           
        //    //_sessionFactory = Fluently.Configure()
        //    //    .Database(MsSqlConfiguration.MsSql2008.ConnectionString(x => x.FromConnectionStringWithKey("UnitOfWorkExample")))
        //    //    .Mappings(x => x.AutoMappings.Add(
        //    //AutoMap.AssemblyOf<Product>(new AutomappingConfiguration()).UseOverridesFromAssemblyOf<ProductOverrides>()))
        //    //    .ExposeConfiguration(config => new SchemaUpdate(config).Execute(false, true))
        //    //    .BuildSessionFactory();
        //}

        public UnitOfWork(ISessionFactory factory)
        {
            this._sessionFactory = factory;
            this._session = _sessionFactory.OpenSession();
        }

        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Commit();
            }
            catch
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();

                throw;
            }
            finally
            {
                _session.Dispose();
            }
        }

        public void Rollback()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();
            }
            finally
            {
                _session.Dispose();
            }
        }

        private IAttachmentRepository attachmentRepository;
        public IAttachmentRepository AttachmentRepository
        {
            get
            {
                if (attachmentRepository == null)
                {
                    attachmentRepository = new AttachmentRepository(this._session);
                }
                return attachmentRepository;
            }
        }

        private ICategoryRepository categoryRepository;
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(this._session);
                }
                return categoryRepository;
            }
        }

        private IHistoryChangeTaskStatusRepository historyChangeTaskStatusRepository;
        public IHistoryChangeTaskStatusRepository HistoryChangeTaskStatusRepository
        {
            get
            {
                if (historyChangeTaskStatusRepository == null)
                {
                    historyChangeTaskStatusRepository = new HistoryChangeTaskStatusRepository(this._session);
                    }
                return historyChangeTaskStatusRepository;
            }
        }

        private IHistoryMessageRepository historyMessageRepository;
        public IHistoryMessageRepository HistoryMessageRepository
        {
            get
            {
                if (historyMessageRepository == null)
                {
                    historyMessageRepository = new HistoryMessageRepository(this._session);
                }
                return historyMessageRepository;
            }
        }

        private IHistoryOfTransfersRepository historyOfTransfersRepository;
        public IHistoryOfTransfersRepository HistoryOfTransfersRepository
        {
            get
            {
                if (historyOfTransfersRepository == null)
                {
                    historyOfTransfersRepository = new HistoryOfTransfersRepository(this._session);
                }
                return historyOfTransfersRepository;
            }
        }

        private IInteractionRepository interactionRepository;
        public IInteractionRepository InteractionRepository
        {
            get
            {
                if (interactionRepository == null)
                {
                    interactionRepository = new InteractionRepository(this._session);
                }
                return interactionRepository;
            }
        }

        private IMessageRepository messageRepository;
        public IMessageRepository MessageRepository
        {
            get
            {
                if (messageRepository == null)
                {
                    messageRepository = new MessageRepository(this._session);
                }
                return messageRepository;
            }
        }

        private IRequestRepository requestRepository;
        public IRequestRepository RequestRepository
        {
            get
            {
                if (requestRepository == null)
                {
                    requestRepository = new RequestRepository(this._session);
                }
                return requestRepository;
            }
        }

        private IResolutionRepository resolutionRepository;
        public IResolutionRepository ResolutionRepository
        {
            get
            {
                if (resolutionRepository == null)
                {
                    resolutionRepository = new ResolutionRepository(this._session);
                }
                return resolutionRepository;
            }
        }

        private ISatisfactionSurveyRepository satisfactionSurveyRepository;
        public ISatisfactionSurveyRepository SatisfactionSurveyRepository
        {
            get
            {
                if (satisfactionSurveyRepository == null)
                {
                    satisfactionSurveyRepository = new SatisfactionSurveyRepository(this._session);
                }
                return satisfactionSurveyRepository;
            }
        }

        private IServiceRepository serviceRepository;
        public IServiceRepository ServiceRepository
        {
            get
            {
                if (serviceRepository == null)
                {
                    serviceRepository = new ServiceRepository(this._session);
                }
                return serviceRepository;
            }
        }

        private ITaskRepository taskRepository;
        public ITaskRepository TaskRepository
        {
            get
            {
                if (taskRepository == null)
                {
                    taskRepository = new TaskRepository(this._session);
                }
                return taskRepository;
            }
        }

        private ITaskStatusRepository taskStatusRepository;
        public ITaskStatusRepository TaskStatusRepository
        {
            get
            {
                if (taskStatusRepository == null)
                {
                    taskStatusRepository = new TaskStatusRepository(this._session);
                }
                return taskStatusRepository;
            }
        }

        private ITopicRepository topicRepository;
        public ITopicRepository TopicRepository
        {
            get
            {
                if (topicRepository == null)
                {
                    topicRepository = new TopicRepository(this._session);
                }
                return topicRepository;
            }
        }

        private ITransferRepository transferRepository;
        public ITransferRepository TransferRepository
        {
            get
            {
                if (transferRepository == null)
                {
                    transferRepository = new TransferRepository(this._session);
                }
                return transferRepository;
            }
        }

        private IUserRepository userRepository;
        public IUserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(this._session);
                }
                return userRepository;
            }
        }

        private IUserStatusRepository userStatusRepository;
        public IUserStatusRepository UserStatusRepository
        {
            get
            {
                if (userStatusRepository == null)
                {
                    userStatusRepository = new UserStatusRepository(this._session);
                }
                return userStatusRepository;
            }
        }
    }
}