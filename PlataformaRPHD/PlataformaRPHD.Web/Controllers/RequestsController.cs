using System.Net;
using System.Web.Mvc;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using System.Collections.Generic;
using PlataformaRPHD.Web.ViewModels;
using AutoMapper;

namespace PlataformaRPHD.Web.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public RequestsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: /Requests/
        public ActionResult Index()
        {
            var requests = unitOfWork.RequestRepository.GetOpenRequestsByUser("Origin,Impact", "info5292");

            IEnumerable<RequestViewModel> result = Mapper.Map<IEnumerable<RequestViewModel>>(requests);

            return View(result);
        }

        // GET: /Requests/
        public ActionResult MyRequestsByState(string state)
        {
            var requests = unitOfWork.RequestRepository.GetRequestsByUserWithStatus("", "info5292", state);

            IEnumerable<RequestViewModel> result = Mapper.Map<IEnumerable<RequestViewModel>>(requests);
            
            return View(result);
        }

        // GET: /Requests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = unitOfWork.RequestRepository.GetRequestByUserWithProperties(id.Value, "Interactions.Service,Origin,Impact");
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }
    }
}
