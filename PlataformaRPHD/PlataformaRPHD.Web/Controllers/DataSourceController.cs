using PlataformaRPHD.Infrastructure.Data.Repositories;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class DataSourceController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public DataSourceController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public JsonResult RootCategories()
        {
            var categories = unitOfWork.CategoryRepository.rootCategories();

            return Json(categories, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOrigins()
        {
            var origins = unitOfWork.OriginRepository.GetAll();

            return Json(origins, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetImpacts()
        {
            var impacts = unitOfWork.ImpactRepository.GetAll();

            return Json(impacts, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetServices()
        {
            var result = unitOfWork.ServiceRepository.GetAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCategories(int id)
        {
            var result = unitOfWork.CategoryRepository.getDownCategories(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}