namespace PlataformaRPHD.Domain.Entities.Entities
{
    public interface ITaskStatus : IEntity
    {
        string GetTypeStatus();

        void ChangeStatus();

        string ToString();
    }
}
