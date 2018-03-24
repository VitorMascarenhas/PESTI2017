
using NUnit.Framework;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using PlataformaRPHD.Web.Controllers;
using System.Web.Mvc;

namespace PlataformaRPHD.Tests.Controllers
{
    [TestFixture]
    public class CategoriesControllerTest
    {
        private CategoriesController controller;
        private IUnitOfWork uow;

        [SetUp]
        public void Init()
        {
            this.uow = new UnitOfWork(new STICketContext());
            
            this.controller = new CategoriesController(this.uow);
        }

        [Test]
        public void TestIndexView()
        {
            var result = controller.Index() as ActionResult;
            Assert.AreEqual("Index", result.GetType().Name);
        }

        [Test]
        public void TestDetailsView()
        {
            var result = controller.Details(2) as ActionResult;
            Assert.AreEqual("Details", result.GetType().Name);
        }
    }
}
