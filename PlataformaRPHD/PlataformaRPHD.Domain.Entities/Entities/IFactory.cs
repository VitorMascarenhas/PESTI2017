namespace PlataformaRPHD.Domain.Entities.Entities
{
    public interface IFactory<Entity>
    {
        Entity Build();
    }
}
