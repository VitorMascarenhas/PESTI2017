using PlataformaRPHD.Domain.Entities.Entities;
using System.Linq;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface IBaseRepository<T> where T : IEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
