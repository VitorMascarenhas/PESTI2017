using System.Net;
using System.Web.Mvc;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using System.Collections.Generic;
using PlataformaRPHD.Web.ViewModels;
using AutoMapper;
using System;

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
            var requests = unitOfWork.RequestRepository.GetOpenRequestsByUser("Origin,Impact,Category", HttpContext.User.Identity.Name);

            IEnumerable<RequestViewModel> result = Mapper.Map<IEnumerable<RequestViewModel>>(requests);

            return View(result);
        }

        public ActionResult ClosedRequests()
        {
            var requests = unitOfWork.RequestRepository.GetClosedRequestsWithoutSatisfactionSurvey(HttpContext.User.Identity.Name, "Origin,Interactions,Category");
            
            return View(requests);
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPatch]
        public ActionResult Search(int? id, string FromTimeOfRegistration, string ToTimeOfRegistration, string Title, string Description)
        {
            DateTime from = Convert.ToDateTime(FromTimeOfRegistration);
            DateTime to = Convert.ToDateTime(ToTimeOfRegistration);

            var requests = unitOfWork.RequestRepository.SearchRquestById(id.Value, from, to, Title, Description, HttpContext.User.Identity.Name);

            IEnumerable<RequestViewModel> result = Mapper.Map<IEnumerable<RequestViewModel>>(requests);

            return View(result);
        }

        public ActionResult SearchAllRequests()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchAllRequests(int? id, string FromTimeOfRegistration, string ToTimeOfRegistration, string Title, string Description)
        {
            DateTime from = Convert.ToDateTime(FromTimeOfRegistration);
            DateTime to = Convert.ToDateTime(ToTimeOfRegistration);

            var requests = unitOfWork.RequestRepository.SearchAllRquestsById(id.Value, from, to, Title, Description);

            IEnumerable<RequestViewModel> result = Mapper.Map<IEnumerable<RequestViewModel>>(requests);

            return RedirectToAction("ResultRequest", result);
        }

        public ActionResult ResultRequest(IEnumerable<RequestViewModel> result)
        {
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

        public ActionResult RequestSatisfaction(int? id)
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
            RequestWithSatisfactionSurveyViewModel requestSatisfaction = Mapper.Map<RequestWithSatisfactionSurveyViewModel>(request);
            
            return View(requestSatisfaction);
        }

        [HttpPost]
        public ActionResult RequestSatisfaction()
        {
            return RedirectToAction("Index");
        }
    }
}
