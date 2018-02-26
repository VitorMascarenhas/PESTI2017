using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.Models;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
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

        public JsonResult GetStatus()
        {
            List<Status> status = new List<Status>();

            status.Add(new Status("Aberto"));
            status.Add(new Status("Fechado"));
            status.Add(new Status("Pendente"));
            
            return Json(status, JsonRequestBehavior.AllowGet);
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

        public JsonResult GetUsersFromAd()
        {
            var pass = ConfigurationManager.AppSettings["passwordAD"];
            var user = ConfigurationManager.AppSettings["usernameAD"];
            var domain = ConfigurationManager.AppSettings["Domain"];
            PrincipalContext AD = new PrincipalContext(ContextType.Domain, domain, user, pass);

            GroupPrincipal group = GroupPrincipal.FindByIdentity(AD, "STICKET_TEC");

            List<UserModel> users = new List<UserModel>();
            
            foreach(var g in group.Members)
            {
                users.Add(new UserModel(g.SamAccountName, g.Name));
            }
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetResolutionTypes()
        {
            List<ResolutionType> resolutions = new List<ResolutionType>();

            resolutions.Add(new ResolutionType(1, "Intervenção"));
            resolutions.Add(new ResolutionType(2, "Instruções"));
            resolutions.Add(new ResolutionType(3, "Resolução impossível"));

            return Json(resolutions, JsonRequestBehavior.AllowGet);
        }
    }
}