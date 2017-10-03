using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public interface IUnitOfWork
    {
        IAttachmentRepository AttachmentRepository { get; }
        
        ICategoryRepository CategoryRepository { get; }

        IChangeTaskStatusRepository ChangeTaskStatusRepository { get; }

        IImpactRepository ImpactRepository { get; }

        IInteractionRepository InteractionRepository { get; }

        IMessageRepository MessageRepository { get; }

        INotificationRepository NotificationRepository { get; }

        IOriginRepository OriginRepository { get; }

        IRequestRepository RequestRepository { get; }

        IResolutionRepository ResolutionRepository { get; }

        ISatisfactionSurveyRepository SatisfactionSurveyRepository { get; }

        IServiceRepository ServiceRepository { get; }

        ITaskRepository TaskRepository { get; }

        ITaskStatusRepository TaskStatusRepository { get; }
        
        ITransferRepository TransferRepository { get; }

        IUserRepository UserRepository { get; }

        void SaveChanges();
    }
}
