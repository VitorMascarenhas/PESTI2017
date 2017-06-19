using NUnit.Framework;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;

namespace PlataformaRPHD.Tests
{


    [TestFixture]
    public class TestClass1
    {
        private UnitOfWork uow;

        [Test]
        public void TestMethod()
        {
            uow = new UnitOfWork(NHibernateConfiguration.Instance);
            
            ICategoryRepository repo = uow.CategoryRepository;

            repo.Create(new Category("cat 1", "desc 1"));
            uow.Commit();
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
    }
}
