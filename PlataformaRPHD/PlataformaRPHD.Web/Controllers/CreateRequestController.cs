using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class CreateRequestController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateRequestController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: CreateRequest
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "OriginId,ServiceId,Category1Id,Category2Id,Category3Id,Category4Id,ImpactId,Contact,Title,Description")] CreateRequestViewModel createRequestViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Create", createRequestViewModel);
            }
            return View("Index", createRequestViewModel);
        }
        
        public ActionResult AddAttachment([Bind(Include = "OriginId,ServiceId,Category1Id,Category2Id,Category3Id,Category4Id,ImpactId,Contact,Title,Description")] CreateRequestViewModel createRequestViewModel)
        {
            return RedirectToAction("Create", createRequestViewModel);
        }

        public ActionResult Create([Bind(Include = "OriginId,ServiceId,Category1Id,Category2Id,Category3Id,Category4Id,ImpactId,Contact,Title,Description")] CreateRequestViewModel createRequestViewModel)
        {
            RequestBuilder builder = new RequestBuilder();
            
            User user1 = unitOfWork.UserRepository.Get(1);
            User user2 = unitOfWork.UserRepository.Get(2);
            
            builder.WithWhoRegistered(user1);
            builder.WithOwner(user2);

            Origin origin = unitOfWork.OriginRepository.Get(createRequestViewModel.OriginId);

            builder.WithOrigin(origin);

            Category category;
            if(createRequestViewModel.Category4Id < 1)
            {
            }
            else
            {
                category = unitOfWork.CategoryRepository.Get(createRequestViewModel.Category4Id);
                builder.WithCategory(category);
            }
            if (createRequestViewModel.Category3Id < 1)
            {
            }
            else
            {
                category = unitOfWork.CategoryRepository.Get(createRequestViewModel.Category3Id);
                builder.WithCategory(category);
            }
            if (createRequestViewModel.Category2Id < 1)
            {
            }
            else
            {
                category = unitOfWork.CategoryRepository.Get(createRequestViewModel.Category2Id);
                builder.WithCategory(category);
            }
            if (createRequestViewModel.Category1Id < 1)
            {
            }
            else
            {
                category = unitOfWork.CategoryRepository.Get(createRequestViewModel.Category1Id);
                builder.WithCategory(category);
            }

            Impact impact = unitOfWork.ImpactRepository.Get(createRequestViewModel.ImpactId);

            builder.WithImpact(impact);

            builder.WithContact(createRequestViewModel.Contact);

            builder.WithTitle(createRequestViewModel.Title);
            
            builder.WithDescription(createRequestViewModel.Description);

            Service service = unitOfWork.ServiceRepository.Get(createRequestViewModel.ServiceId);
            
            InteractionBuilder interactionBuilder = new InteractionBuilder();

            interactionBuilder.WithTitle(createRequestViewModel.Title);
            interactionBuilder.WithService(service);
            Interaction interaction = interactionBuilder.Build();
            
            Request request = builder.Build();
            request.AddInteraction(interaction);

            unitOfWork.RequestRepository.Insert(request);
            unitOfWork.SaveChanges();
            
            return RedirectToAction("Index", "Home");
        }
    }
}   