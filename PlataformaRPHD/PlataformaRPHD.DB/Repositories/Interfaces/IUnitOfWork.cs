namespace PlataformaRPHD.DB.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IAttachmentRepository AttachmentRepository { get; }

        ICategoryRepository CategoryRepository { get; }
        
        IInteractionRepository InteractionRepository { get; }

        ITopicRepository TopicRepository { get; }

        IUserRepository UserRepository { get; }
    }
}
