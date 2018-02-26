using AutoMapper;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.Services;
using PlataformaRPHD.Web.ViewModels;
using System.Collections.Generic;
using System.Net;
using System.Security.Principal;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class TasksController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TasksController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: /Tasks/
        public ActionResult Index()
        {
            var interactions = unitOfWork.InteractionRepository.GetInteractionsByOpenTaskStatus(HttpContext.User.Identity.Name, "Task,service,Request");
            
            var result = Mapper.Map<IEnumerable<InteractionViewModel>>(interactions);

            return View(result);
        }

        // GET: /Tasks/ClosedTasks/
        public ActionResult ClosedTasks()
        {
            var interactions = unitOfWork.InteractionRepository.GetInteractionsByCloseTaskStatus(HttpContext.User.Identity.Name, "Tasks.Status,service,Request.TimeOfRegistration");

            var result = Mapper.Map<IEnumerable<InteractionViewModel>>(interactions);

            return View(result);
        }

        // GET: /Tasks/PendingTasks/
        public ActionResult PendingTasks()
        {
            var interactions = unitOfWork.InteractionRepository.GetInteractionsByPendingTaskStatus(HttpContext.User.Identity.Name, "Tasks.Status,service,Request.TimeOfRegistration");

            var result = Mapper.Map<IEnumerable<InteractionViewModel>>(interactions);

            return View(result);
        }

        // GET: /Tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interaction interaction = unitOfWork.InteractionRepository.GetInteractionByTaskId(id.Value, "Request.Impact,Request.Origin,Request.Category,Request.Owner,Task,service");
            if (interaction == null)
            {
                return HttpNotFound();
            }
            InteractionViewModel interactionViewModel = Mapper.Map<InteractionViewModel>(interaction);
            return View(interactionViewModel);
        }

        // GET: /Tasks/WithoutUser/
        public ActionResult WithoutUser()
        {
            var interactions = unitOfWork.InteractionRepository.GetInteractionsByTaskWithoutUser("Task,Request,Request.Owner");

            return View(interactions);
        }

        // GET: /Tasks/WithoutUser/
        public ActionResult Transfer(int? id)
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
        public ActionResult Transfer([Bind(Include = "Id,userId,Description")] InteractionViewModel interactionViewModel)
        {
            if (ModelState.IsValid)
            {
                Interaction interaction = unitOfWork.InteractionRepository.GetInteractionById(interactionViewModel.Id, "Task,Task.Owner");

                UserService us = new UserService();
                User auth = us.UpdateUserInDB(HttpContext.User.Identity.Name);
                User forUser = us.UpdateUserInDB(interactionViewModel.userId);

                interaction.Task.Transfer(forUser, auth, interactionViewModel.Description);
                unitOfWork.TaskRepository.Update(interaction.Task);
                unitOfWork.SaveChanges();

                return RedirectToAction("WithoutUser");
            }
            return View(interactionViewModel);
        }

        public ActionResult ChangeStatus(int? id)
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
        public ActionResult ChangeStatus([Bind(Include = "Id,StatusDescription,statusId")] InteractionViewModel interactionViewModel)
        {
            if (ModelState.IsValid)
            {
                Interaction interaction = unitOfWork.InteractionRepository.GetInteractionById(interactionViewModel.Id, "Task");

                User auth = unitOfWork.UserRepository.GetUserBySamAccountName(HttpContext.User.Identity.Name);

                interaction.Task.ChangeStatus(interactionViewModel.statusId, auth, interactionViewModel.statusDescription);
                
                unitOfWork.TaskRepository.Update(interaction.Task);
                unitOfWork.SaveChanges();

                return RedirectToAction("WithoutUser");
            }
            return View(interactionViewModel);
        }
    }
}
