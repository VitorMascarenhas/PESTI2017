namespace PlataformaRPHD.DB.Domain
{
    public interface ITaskStatus
    {
        string GetTypeStatus();

        void ChangeStatus();
    }
}
