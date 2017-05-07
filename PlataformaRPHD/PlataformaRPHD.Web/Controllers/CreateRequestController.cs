using AutoMapper;
using PlataformaRPHD.DB.Domain;
using PlataformaRPHD.DB.Repositories.Classes;
using PlataformaRPHD.DB.Repositories.Interfaces;
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
            IEnumerable<CategoryViewModel> data;
            IEnumerable<Category> categories = unitOfWork.CategoryRepository.GetAll();
            data = Mapper.Map<IEnumerable<CategoryViewModel>>(categories);
            CreateRequestViewModel result = new CreateRequestViewModel();
            result.categories = data;
            result.Title = "Pedido de colaboração";
            result.Description = "Computador 163 não liga.";
            return View("index", result);
        }
    }
}