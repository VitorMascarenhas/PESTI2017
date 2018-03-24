using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;
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

        //[Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM,STICKET_ADMAPLIC")]
        public ActionResult Index()
        {
            DataViewModel dvm = new DataViewModel();
            dvm.PedidosAbertos = unitOfWork.RequestRepository.GetOpenRequestsByUser("", HttpContext.User.Identity.Name).Count();
            dvm.PedidosFechados = unitOfWork.RequestRepository.GetClosedRequestsWithoutSatisfactionSurvey(HttpContext.User.Identity.Name, "").Count();
            dvm.TarefasAbertos = unitOfWork.InteractionRepository.GetInteractionsByOpenTaskStatus(HttpContext.User.Identity.Name, "").Count();
            dvm.TarefasPendentes = unitOfWork.InteractionRepository.GetInteractionsByPendingTaskStatus(HttpContext.User.Identity.Name, "").Count();
            dvm.TarefasFechadas = unitOfWork.InteractionRepository.GetInteractionsByCloseTaskStatus(HttpContext.User.Identity.Name, "").Count();

            return View(dvm);
        }

        //[Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM,STICKET_ADMAPLIC")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //[Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM,STICKET_ADMAPLIC")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}