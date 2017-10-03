using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace STICket.WebServices.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly IUnitOfWork unitOfWork;

        public CategoriesController()
        {
            this.unitOfWork = new UnitOfWork(new STICketContext());
        }

        // GET api/<controller>
        public IEnumerable<Category> Get()
        {
            return unitOfWork.CategoryRepository.GetAll();
        }

        // GET api/<controller>/5
        public IEnumerable<Category> GetDescendentCategories(int id)
        {
            return unitOfWork.CategoryRepository.getDownCategories(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}