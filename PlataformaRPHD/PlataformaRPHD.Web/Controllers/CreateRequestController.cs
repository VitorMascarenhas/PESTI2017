using PlataformaRPHD.Infrastructure.Data.Repositories;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class CreateRequestController : Controller
    {
        IUnitOfWork unitOfWork;

        public CreateRequestController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: CreateRequest
        public ActionResult Index()
        {
            return View();
        }
    }
}