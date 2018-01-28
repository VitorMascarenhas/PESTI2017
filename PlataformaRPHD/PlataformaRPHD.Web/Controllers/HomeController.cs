using PlataformaRPHD.Infrastructure.Data.Repositories;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        
        public HomeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM,STICKET_ADMAPLIC")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM,STICKET_ADMAPLIC")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM,STICKET_ADMAPLIC")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}