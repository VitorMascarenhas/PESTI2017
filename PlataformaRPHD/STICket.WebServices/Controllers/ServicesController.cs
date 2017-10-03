using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace STICket.WebServices.Controllers
{
    public class ServicesController : ApiController
    {
        private readonly IUnitOfWork unitOfWork;
        
        public ServicesController()
        {
            this.unitOfWork = new UnitOfWork(new STICketContext());
        }

        // GET api/<controller>
        public IEnumerable<Service> Get()
        {
            return unitOfWork.ServiceRepository.GetAll();
        }

        // GET api/<controller>/5
        public Service Get(int id)
        {
            return unitOfWork.ServiceRepository.Get(id);
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