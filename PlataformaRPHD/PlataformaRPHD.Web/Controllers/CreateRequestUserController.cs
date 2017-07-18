using AutoMapper;
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

        // GET: CreateRequest
        public ActionResult Index()
        {
            var allCategories = unitOfWork.CategoryRepository.GetAll();
            var allServices = unitOfWork.ServiceRepository.GetAll();

            CreateRequestUserViewModel result = new CreateRequestUserViewModel();
            result.categories = Mapper.Map<IEnumerable<CategoryViewModel>>(allCategories);
            result.services = Mapper.Map<IEnumerable<ServiceViewModel>>(allServices);

            return View(result);
        }

        [HttpPost]
        public ActionResult Index(CreateRequestUserViewModel createRequestUser)
        {
            return RedirectToAction("AddAttachment", createRequestUser);
        }

        // GET
        public ActionResult AddAttachment(CreateRequestUserViewModel createRequestUser)
        {
            return RedirectToAction("Index", createRequestUser);
        }
        
        public ActionResult Create(CreateRequestUserViewModel createRequestUserViewModel)
        {
            return RedirectToRoute("Home");
        }
    }
}
