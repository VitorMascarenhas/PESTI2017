using AutoMapper;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data;
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
            var wizards = unitOfWork.WizardRepository.GetMyWizards(HttpContext.User.Identity.Name);

            IEnumerable<WizardViewModel> result = Mapper.Map<IEnumerable<WizardViewModel>>(wizards);

            return View(result);
        }

        //Acesso a administradores
        // GET: Wizard
        public ActionResult NotApproved()
        {
            var wizards = unitOfWork.WizardRepository.GetNotApprovedWizards();

            IEnumerable<WizardViewModel> result = Mapper.Map<IEnumerable<WizardViewModel>>(wizards);

            return View(result);
        }

        //para administrador
        // GET: /Wizard/Aprov/5
        public ActionResult Approv(int? id)
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
        
        //Tecnico e administrador
        public ActionResult CreateWizard()
        {
            return View();
        }

        //Tecnico e administrador
        [HttpPost]
        public ActionResult CreateWizard([Bind(Include = "Id,Title,Step1,Step2,Step3")] WizardViewModel wizardViewModel, HttpPostedFileBase File1, HttpPostedFileBase File2, HttpPostedFileBase File3)
        {
            if(ModelState.IsValid)
            {
                Wizard wizard = new Wizard(wizardViewModel.Title);
                if((File1 != null && File1.ContentLength > 0) &&
                   (File2 != null && File2.ContentLength > 0) &&
                   (File3 != null && File3.ContentLength > 0))
                {
                    var f1 = new StepViewModel
                    {
                        ImageType = File1.ContentType
                    };
                    var f2 = new StepViewModel
                    {
                        ImageType = File2.ContentType
                    };
                    var f3 = new StepViewModel
                    {
                        ImageType = File3.ContentType
                    };
                    using (var reader1 = new BinaryReader(File1.InputStream))
                    {
                        f1.ImageContent = reader1.ReadBytes(File1.ContentLength);
                    }
                    using (var reader2 = new BinaryReader(File2.InputStream))
                    {
                        f2.ImageContent = reader2.ReadBytes(File2.ContentLength);
                    }
                    using (var reader3 = new BinaryReader(File3.InputStream))
                    {
                        f3.ImageContent = reader3.ReadBytes(File3.ContentLength);
                    }
                    Step s1 = new Step(null, wizardViewModel.Step1, f1.ImageContent, f1.ImageType);
                    Step s2 = new Step(s1, wizardViewModel.Step2, f2.ImageContent, f2.ImageType);
                    Step s3 = new Step(s2, wizardViewModel.Step3, f3.ImageContent, f3.ImageType);

                    ActiveDirectoryReadOnlyRepository ad = new ActiveDirectoryReadOnlyRepository();
                    ActiveDirectoryUser adu = ad.GetUser(HttpContext.User.Identity.Name);

                    User user;
                    user = unitOfWork.UserRepository.GetUserBySamAccountName(HttpContext.User.Identity.Name);
                    if (user == null)
                    {
                        UserName un = new UserName(adu.Name, adu.Surname);
                        user = new User(un, adu.SamAccountName, adu.EmailAddress, "");
                    }

                    wizard.Step = s1;
                    wizard.CreateBy = user;
                }
                unitOfWork.WizardRepository.Insert(wizard);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(wizardViewModel);
        }
    }
}