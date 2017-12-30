using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class CreateRequestUserController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateRequestUserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // para utilizadores, tecnicos e administradores
        // GET: CreateRequest
        //[Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM")]
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM")]
        [HttpPost]
        public ActionResult Index([Bind(Include = "ServiceId,Category1Id,Category2Id,Category3Id,Category4Id,ImpactId,Contact,Title,Description")] CreateRequestUserViewModel createRequestUserViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Create", createRequestUserViewModel);
            }
            return View("Index", createRequestUserViewModel);
        }

        //[Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM")]
        public ActionResult AddAttachment([Bind(Include = "ServiceId,Category1Id,Category2Id,Category3Id,Category4Id,ImpactId,Contact,Title,Description")] CreateRequestViewModel createRequestUserViewModel)
        {
            return RedirectToAction("Create", createRequestUserViewModel);
        }

        //[Authorize(Roles = "STICKET_UTL,STICKET_TEC,STICKET_ADM")]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "ServiceId,Category1Id,Category2Id,Category3Id,Category4Id,ImpactId,Contact,Title,Description")] CreateRequestViewModel createRequestUserViewModel)
        {
            RequestBuilder builder = new RequestBuilder();
            
            var user1 = unitOfWork.UserRepository.Get(1);

            builder.WithWhoRegistered(user1);
            builder.WithOwner(user1);

            Origin origin = unitOfWork.OriginRepository.GetOriginByName("Aplicação");

            builder.WithOrigin(origin);
            builder.WithContact(createRequestUserViewModel.Contact);

            Category category;
            if (createRequestUserViewModel.Category4Id < 1)
            {
            }
            else
            {
                category = unitOfWork.CategoryRepository.Get(createRequestUserViewModel.Category4Id);
                builder.WithCategory(category);
            }
            if (createRequestUserViewModel.Category3Id < 1)
            {
            }
            else
            {
                category = unitOfWork.CategoryRepository.Get(createRequestUserViewModel.Category3Id);
                builder.WithCategory(category);
            }
            if (createRequestUserViewModel.Category2Id < 1)
            {
            }
            else
            {
                category = unitOfWork.CategoryRepository.Get(createRequestUserViewModel.Category2Id);
                builder.WithCategory(category);
            }
            if (createRequestUserViewModel.Category1Id < 1)
            {
            }
            else
            {
                category = unitOfWork.CategoryRepository.Get(createRequestUserViewModel.Category1Id);
                builder.WithCategory(category);
            }

            Impact impact = unitOfWork.ImpactRepository.Get(createRequestUserViewModel.ImpactId);

            builder.WithContact(createRequestUserViewModel.Contact);

            builder.WithImpact(impact);

            builder.WithTitle(createRequestUserViewModel.Title);
            builder.WithDescription(createRequestUserViewModel.Description);

            Service service = unitOfWork.ServiceRepository.Get(createRequestUserViewModel.ServiceId);

            InteractionBuilder interactionBuilder = new InteractionBuilder();

            interactionBuilder.WithTitle(createRequestUserViewModel.Title);
            interactionBuilder.WithService(service);
            Interaction interaction = interactionBuilder.Build();

            Request request = builder.Build();
            request.AddInteraction(interaction);

            unitOfWork.RequestRepository.Insert(request);
            unitOfWork.SaveChanges();

            List<string> mails = new List<string>();
            mails.Add("vamd82@gmail.com");
            MailService ms = new MailService();
            ms.CreateMail(mails, "Assunto", "Corpo");
            ms.Send();

            return RedirectToAction("Index", "Home");
        }
    }
}