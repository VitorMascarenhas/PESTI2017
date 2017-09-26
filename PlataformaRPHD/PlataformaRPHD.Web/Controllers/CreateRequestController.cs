using AutoMapper;
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
            var allCategories = unitOfWork.CategoryRepository.GetAll();
            var allServices = unitOfWork.ServiceRepository.GetAll();

            CreateRequestViewModel result = new CreateRequestViewModel();
            result.categories = Mapper.Map<IEnumerable<CategoryViewModel>>(allCategories);
            result.services = Mapper.Map<IEnumerable<ServiceViewModel>>(allServices);

            return View(result);
        }

        [HttpPatch]
        public ActionResult Index(CreateRequestViewModel createRequest)
        {
            return RedirectToAction("AddAttachment", createRequest);
        }
        
        //GET
        public ActionResult AddAttachment(CreateRequestViewModel createRequest)
        {
            return RedirectToAction("Index", createRequest);
        }
    }
}