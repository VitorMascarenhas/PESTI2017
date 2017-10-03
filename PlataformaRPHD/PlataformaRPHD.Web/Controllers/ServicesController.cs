using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using PlataformaRPHD.Web.ViewModels;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Domain.Entities.Entities;
using AutoMapper;

namespace PlataformaRPHD.Web.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ServicesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: /Services/
        public ActionResult Index()
        {
            var services = unitOfWork.ServiceRepository.GetAll();
            var result = Mapper.Map<IEnumerable<ServiceViewModel>>(services);

            return View(result);
        }

        // GET: /Services/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var service = unitOfWork.ServiceRepository.Get(id.Value);
            
            ServiceViewModel serviceViewModel = Mapper.Map<ServiceViewModel>(service);
            
            if (serviceViewModel == null)
            {
                return HttpNotFound();
            }
            return View(serviceViewModel);
        }

        // GET: /Services/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name")] ServiceViewModel serviceViewModel)
        {
            if (ModelState.IsValid)
            {
                var service = Mapper.Map<Service>(serviceViewModel);
                unitOfWork.ServiceRepository.Insert(service);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviceViewModel);
        }

        // GET: /Services/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var service = unitOfWork.ServiceRepository.Get(id.Value);
            var serviceViewModel = Mapper.Map<ServiceViewModel>(service);
            if (serviceViewModel == null)
            {
                return HttpNotFound();
            }
            return View(serviceViewModel);
        }

        // POST: /Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name")] ServiceViewModel serviceViewModel)
        {
            if (ModelState.IsValid)
            {
                var service = Mapper.Map<Service>(serviceViewModel);
                unitOfWork.ServiceRepository.Update(service);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviceViewModel);
        }

        // GET: /Services/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var service = unitOfWork.ServiceRepository.Get(id.Value);
            var serviceViewModel = Mapper.Map<ServiceViewModel>(service);
            if (serviceViewModel == null)
            {
                return HttpNotFound();
            }
            return View(serviceViewModel);
        }

        // POST: /Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var service = unitOfWork.ServiceRepository.Get(id);
            unitOfWork.ServiceRepository.Delete(service);
            unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
