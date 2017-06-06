using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public interface IUnitOfWork
    {
        IAttachmentRepository AttachmentRepository { get; }

        ICategoryRepository CategoryRepository { get; }       

        IHistoryChangeTaskStatusRepository HistoryChangeTaskStatusRepository { get; }

        IHistoryMessageRepository HistoryMessageRepository { get; }

        IHistoryOfTransfersRepository HistoryOfTransfersRepository { get; }

        IInteractionRepository InteractionRepository { get; }

        IMessageRepository MessageRepository { get; }

        IRequestRepository RequestRepository { get; }

        IResolutionRepository ResolutionRepository { get; }

        ISatisfactionSurveyRepository SatisfactionSurveyRepository { get; }

        IServiceRepository ServiceRepository { get; }

        ITaskRepository TaskRepository { get; }

        ITaskStatusRepository TaskStatusRepository { get; }

        ITopicRepository TopicRepository { get; }

        ITransferRepository TransferRepository { get; }

        IUserRepository UserRepository { get; }

        IUserStatusRepository UserStatusRepository { get; }

        void BeginTransaction();

        void Commit();

        void Rollback();
    }
}
