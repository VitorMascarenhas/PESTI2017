using AutoMapper;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.ViewModels;
using System.Net;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class InteractionController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public InteractionController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Interaction
        public ActionResult InteractionDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interaction interaction = unitOfWork.InteractionRepository.GetInteractionWithProperties(id.Value, "HistoryMessages,Request,Task");
            if (interaction == null)
            {
                return HttpNotFound();
            }
            InteractionViewModel interactionViewModel = new InteractionViewModel();
            interactionViewModel = Mapper.Map<InteractionViewModel>(interaction);
            
            return View(interactionViewModel);
        }
    }
}