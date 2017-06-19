using AutoMapper;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.ViewModels;
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

        public ActionResult Index()
        {
            var model = new CategoryViewModel { Id = 1, Description = "sdfsdf", Name = "dsdsd" };
            //var category = new Category("Categoria", "Descrição da categoria");
            //unitOfWork.CategoryRepository.Create(category);
            //var cat = unitOfWork.CategoryRepository.GetById(1);
            //var model = Mapper.Map<CategoryViewModel>(cat);

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}