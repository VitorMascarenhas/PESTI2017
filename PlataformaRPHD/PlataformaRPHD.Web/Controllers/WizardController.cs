using AutoMapper;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class WizardController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public WizardController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //Acesso a utilizadores tecnicos e administradores
        // GET: Wizard
        public ActionResult Index()
        {
            var wizards = unitOfWork.WizardRepository.GetApprovedWizards();

            IEnumerable<WizardViewModel> result = Mapper.Map<IEnumerable<WizardViewModel>>(wizards);

            return View(result);
        }

        public ActionResult MyWizards()
        {
            return View();
        }

        //Acesso a administradores
        // GET: Wizard
        public ActionResult NotApproved()
        {
            var wizards = unitOfWork.WizardRepository.GetNotApprovedWizards();

            IEnumerable<WizardViewModel> result = Mapper.Map<IEnumerable<WizardViewModel>>(wizards);

            return View(result);
        }


        //Acesso a utilizadores tecnicos e administradores
        // GET: /Wizard/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wizard wizard = unitOfWork.WizardRepository.Get(id.Value);
            if (wizard == null)
            {
                return HttpNotFound();
            }
            WizardViewModel wizardViewModel = Mapper.Map<WizardViewModel>(wizard);
            return View(wizardViewModel);
        }

        //para administrador
        // GET: /Wizard/Aprov/5
        public ActionResult Aprov(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wizard wizard = unitOfWork.WizardRepository.Get(id.Value);
            wizard.Approv();
            unitOfWork.SaveChanges();
            return Redirect("NotApproved");
        }

        //Tecnico e administrador
        public ActionResult CreateWizard()
        {
            return View();
        }

        //Tecnico e administrador
        [HttpPost]
        public ActionResult CreateWizard(string title, string step1, string step2, string step3, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3)
        {
            byte[] image1 = null;
            byte[] image2 = null;
            byte[] image3 = null;

            using (MemoryStream memoryStream1 = new MemoryStream())
            {
                file1.InputStream.CopyTo(memoryStream1);
                image1 = memoryStream1.ToArray();
            }
            using (MemoryStream memoryStream2 = new MemoryStream())
            {
                file2.InputStream.CopyTo(memoryStream2);
                image2 = memoryStream2.ToArray();
            }
            using (MemoryStream memoryStream3 = new MemoryStream())
            {
                file3.InputStream.CopyTo(memoryStream3);
                image3 = memoryStream3.ToArray();
            }

            Step s1 = new Step(null, step1, image1);

            Step s2 = new Step(s1, step2, image2);

            Step s3 = new Step(s2, step3, image3);

            Wizard wizard = new Wizard(title, s1);

            unitOfWork.WizardRepository.Insert(wizard);
            unitOfWork.SaveChanges();

            return Redirect("NotApprov");
        }
    }
}