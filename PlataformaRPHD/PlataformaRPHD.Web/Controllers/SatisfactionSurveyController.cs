using AutoMapper;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.ViewModels;
using System.Net;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class SatisfactionSurveyController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SatisfactionSurveyController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: SatisfactionSurvey
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = unitOfWork.RequestRepository.GetRequestByUserWithProperties(id.Value, "Interactions.Service,Origin,Impact");
            RequestWithSatisfactionSurveyViewModel requestViewModel = Mapper.Map<RequestWithSatisfactionSurveyViewModel>(request);
            if (requestViewModel == null)
            {
                return HttpNotFound();
            }
            return View(requestViewModel);
        }

        [HttpPost]
        public ActionResult Index(RequestWithSatisfactionSurveyViewModel requestWithSatisfactionSurveyViewModel)
        {
            if (ModelState.IsValid)
            {
                Request request = unitOfWork.RequestRepository.Get(requestWithSatisfactionSurveyViewModel.Id);
                SatisfactionSurvey satisfactionSurvey = new SatisfactionSurvey(request, requestWithSatisfactionSurveyViewModel.answer1, requestWithSatisfactionSurveyViewModel.answer2, requestWithSatisfactionSurveyViewModel.suggestion);
                unitOfWork.SatisfactionSurveyRepository.Insert(satisfactionSurvey);
                unitOfWork.SaveChanges();
                return View("Index", "Requests");
            }

            return View("Index", "Home");
        }
    }
}