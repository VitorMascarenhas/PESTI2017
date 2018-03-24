using System.Net;
using System.Web.Mvc;
using PlataformaRPHD.Web.ViewModels;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Domain.Entities.Entities;
using AutoMapper;
using System.Collections.Generic;

namespace PlataformaRPHD.Web.Controllers
{

    public class CategoriesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CategoriesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: /CategoriesViewModels/
        //[Authorize(Roles = "STICKET_ADMAPLIC")]
        public ActionResult Index()
        {
            var categories = unitOfWork.CategoryRepository.GetAll();
            var result = Mapper.Map<IEnumerable<CategoryViewModel>>(categories);
            return View("Index", result);
        }

        // GET: /CategoriesViewModels/Details/5
        //[Authorize(Roles = "STICKET_ADMAPLIC")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = unitOfWork.CategoryRepository.Get(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            CategoryViewModel categoryViewModel = Mapper.Map<CategoryViewModel>(category);
            return View(categoryViewModel);
        }

        // GET: /CategoriesViewModels/Create
        //[Authorize(Roles = "STICKET_ADMAPLIC")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /CategoriesViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[Authorize(Roles = "STICKET_ADMAPLIC")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,ParentId,Name,Description,HasWizard")] CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = Mapper.Map<Category>(categoryViewModel);
                unitOfWork.CategoryRepository.Insert(category);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryViewModel);
        }

        // GET: /CategoriesViewModels/Edit/5
        //[Authorize(Roles = "STICKET_ADMAPLIC")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = unitOfWork.CategoryRepository.Get(id.Value);
            CategoryViewModel categoryViewModel = Mapper.Map<CategoryViewModel>(category);
            if (categoryViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoryViewModel);
        }

        // POST: /CategoriesViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[Authorize(Roles = "STICKET_ADMAPLIC")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,ParentId,Name,Description,HasWizard")] CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = unitOfWork.CategoryRepository.Get(categoryViewModel.Id);
                category.Name = categoryViewModel.Name;
                category.Description = categoryViewModel.Description;
                unitOfWork.CategoryRepository.Update(category);
                unitOfWork.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return View(categoryViewModel);
        }

        // GET: /CategoriesViewModels/Delete/5
        //[Authorize(Roles = "STICKET_ADMAPLIC")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = unitOfWork.CategoryRepository.Get(id.Value);
            CategoryViewModel categoryViewModel = Mapper.Map<CategoryViewModel>(category);
            if (categoryViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoryViewModel);
        }

        // POST: /CategoriesViewModels/Delete/5
        //[Authorize(Roles = "STICKET_ADMAPLIC")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = unitOfWork.CategoryRepository.Get(id);
            unitOfWork.CategoryRepository.Delete(category);
            unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
