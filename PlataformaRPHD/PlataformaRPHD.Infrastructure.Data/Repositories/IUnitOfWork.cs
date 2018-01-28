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
        
        IOriginRepository OriginRepository { get; }

        IRequestRepository RequestRepository { get; }

        IResolutionRepository ResolutionRepository { get; }

        ISatisfactionSurveyRepository SatisfactionSurveyRepository { get; }

        IServiceRepository ServiceRepository { get; }

        IStepRepository StepRepository { get; }

        ITaskRepository TaskRepository { get; }
        
        ITransferRepository TransferRepository { get; }

        IUserRepository UserRepository { get; }

        IWizardRepository WizardRepository { get; }

        void SaveChanges();
    }
}
