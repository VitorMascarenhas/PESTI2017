using AutoMapper;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
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
            var interaction = unitOfWork.InteractionRepository.GetAll("Task.Owner");
            
            var result = Mapper.Map<IEnumerable<InteractionViewModel>>(interaction);

            return View(result);
        }
        
        // CRIAR VISTA PARA TAREFAS ABERTAS
        public ActionResult MyTasksStatus(string status)
        {
            var tasks = unitOfWork.TaskRepository.GetTaskByUserWithState("info5292", status);

            IEnumerable<TaskViewModel> result = Mapper.Map<IEnumerable<TaskViewModel>>(tasks);

            return View(result);
        }

        // GET: /Tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var interaction = unitOfWork.InteractionRepository.GetInteractionWithProperties(id.Value, "Request.Owner,Request.Category,Request.Origin,Request.Impact,Service,Task.Owner");


            if (interaction == null)
            {
                return HttpNotFound();
            }
            
            InteractionViewModel interactionViewModel = Mapper.Map<InteractionViewModel>(interaction);
            
            return View(interactionViewModel);
        }
        
        // GET: /Tasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var interaction = unitOfWork.InteractionRepository.Get(id.Value);

            InteractionViewModel interactionViewModel = Mapper.Map<InteractionViewModel>(interaction);

            if (interactionViewModel == null)
            {
                return HttpNotFound();
            }
            return View(interactionViewModel);
        }

        // POST: /Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InteractionViewModel interactionViewModel)
        {
            if (ModelState.IsValid)
            {
                var interaction = unitOfWork.InteractionRepository.GetInteractionWithProperties(interactionViewModel.Id, "Task.Owner");
                interaction.Task.Owner.Id = interactionViewModel.Task.Owner.Id;

                unitOfWork.InteractionRepository.Update(interaction);
                unitOfWork.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(interactionViewModel);
        }
    }
}
