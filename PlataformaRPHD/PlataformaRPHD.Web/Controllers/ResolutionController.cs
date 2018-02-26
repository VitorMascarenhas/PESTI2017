using AutoMapper;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class ResolutionController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ResolutionController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Resolution/id
        public ActionResult Resolve(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interaction interaction = unitOfWork.InteractionRepository.GetInteractionById(id.Value, "Request.Impact,Request.Origin,Request.Category,Request.Owner,Task,service");
            if (interaction == null)
            {
                return HttpNotFound();
            }
            InteractionViewModel interactionViewModel = Mapper.Map<InteractionViewModel>(interaction);
            return View(interactionViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus([Bind(Include = "Id,StatusDescription,statusId,ResolutionType,ResolutionText")] InteractionViewModel interactionViewModel)
        {
            if (ModelState.IsValid)
            {
                Interaction interaction = unitOfWork.InteractionRepository.GetInteractionById(interactionViewModel.Id, "Task");

                Resolution resolution = new Resolution(interactionViewModel.ResolutionText, interactionViewModel.ResolutionType);
                User auth = unitOfWork.UserRepository.GetUserBySamAccountName(HttpContext.User.Identity.Name);
                interaction.Task.ChangeStatus("Fechado", auth, interactionViewModel.ResolutionText);
                resolution.AddTask(interaction.Task);

                unitOfWork.ResolutionRepository.Update(resolution);
                unitOfWork.SaveChanges();

                return RedirectToAction("WithoutUser");
            }
            return View(interactionViewModel);
        }
    }
}