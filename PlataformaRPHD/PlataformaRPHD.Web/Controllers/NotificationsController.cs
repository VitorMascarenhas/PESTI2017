using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;

namespace PlataformaRPHD.Web.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public NotificationsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        // GET: /Notifications/
        public ActionResult Index()
        {
            var notifications = unitOfWork.NotificationRepository.GetAll();
            return View(notifications);
        }

        // GET: /Notifications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notification notification = unitOfWork.NotificationRepository.Get(id.Value);
            if (notification == null)
            {
                return HttpNotFound();
            }
            return View(notification);
        }

        // GET: /Notifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Notifications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,OpenSubject,CloseSubject,OpenBody,CloseBody")] Notification notification)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.NotificationRepository.Insert(notification);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notification);
        }

        // GET: /Notifications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notification notification = unitOfWork.NotificationRepository.Get(id.Value);
            if (notification == null)
            {
                return HttpNotFound();
            }
            return View(notification);
        }

        // POST: /Notifications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,OpenSubject,CloseSubject,OpenBody,CloseBody")] Notification notification)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.NotificationRepository.Update(notification);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notification);
        }

        // GET: /Notifications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notification notification = unitOfWork.NotificationRepository.Get(id.Value);
            if (notification == null)
            {
                return HttpNotFound();
            }
            return View(notification);
        }

        // POST: /Notifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notification notification = unitOfWork.NotificationRepository.Get(id);
            unitOfWork.NotificationRepository.Delete(notification);
            unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
