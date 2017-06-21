using PlataformaRPHD.Domain.Interfaces.Interfaces;
using System;
using System.Data.Entity;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        private IAttachmentRepository attachmentRepository;
        public IAttachmentRepository AttachmentRepository
        {
            get
            {
                if (attachmentRepository == null)
                {
                    attachmentRepository = new AttachmentRepository(this.context);
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
                    categoryRepository = new CategoryRepository(this.context);
                }
                return categoryRepository;
            }
        }

        private IInteractionRepository interactionRepository;
        public IInteractionRepository InteractionRepository
        {
            get
            {
                if (interactionRepository == null)
                {
                    interactionRepository = new InteractionRepository(this.context);
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
                    messageRepository = new MessageRepository(this.context);
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
                    requestRepository = new RequestRepository(this.context);
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
                    resolutionRepository = new ResolutionRepository(this.context);
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
                    satisfactionSurveyRepository = new SatisfactionSurveyRepository(this.context);
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
                    serviceRepository = new ServiceRepository(this.context);
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
                    taskRepository = new TaskRepository(this.context);
                }
                return taskRepository;
            }
        }
        
        private ITopicRepository topicRepository;
        public ITopicRepository TopicRepository
        {
            get
            {
                if (topicRepository == null)
                {
                    topicRepository = new TopicRepository(this.context);
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
                    transferRepository = new TransferRepository(this.context);
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
                    userRepository = new UserRepository(this.context);
                }
                return userRepository;
            }
        }

        public void SaveChanges()
        {
            //TODO: Ver transaction
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
