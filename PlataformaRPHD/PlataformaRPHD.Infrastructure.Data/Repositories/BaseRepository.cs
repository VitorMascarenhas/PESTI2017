using NHibernate;
using NHibernate.Linq;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using System.Linq;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : IEntity
    {
        //private IUnitOfWork _unitOfWork;

        private readonly ISession _session;

        public BaseRepository(ISession session)
        {
            this._session = session;
        }

        //protected ISession Session { get { return _unitOfWork.Session; } }

        public IQueryable<T> GetAll()
        {
            return _session.Query<T>();
        }

        public T GetById(int id)
        {
            return _session.Get<T>(id);
        }

        public void Create(T entity)
        {
            _session.Save(entity);
        }

        public void Update(T entity)
        {
            _session.Update(entity);
        }

        public void Delete(int id)
        {
            _session.Delete(_session.Load<T>(id));
        }
    }
}
