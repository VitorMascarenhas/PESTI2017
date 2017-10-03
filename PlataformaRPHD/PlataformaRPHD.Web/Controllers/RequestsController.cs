using System.Net;
using System.Web.Mvc;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;

namespace PlataformaRPHD.Web.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public RequestsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: /Requests/
        public ActionResult Index()
        {
            var result = unitOfWork.RequestRepository.GetAll("Origin,Impact");
            return View(result);
        }

        // GET: /Requests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = unitOfWork.RequestRepository.GetRequestWithProperties(id.Value, "Interactions.Service,Origin,Impact");
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }
    }
}
