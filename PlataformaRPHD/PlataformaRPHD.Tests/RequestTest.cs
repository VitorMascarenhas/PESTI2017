using NUnit.Framework;
using PlataformaRPHD.DB.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaRPHD.Tests
{
    [TestFixture]
    public class RequestTest
    {
        [Test]
        public void ConstructorTest()
        {
            UserName un1 = new UserName("Vitor", "Mascarenhas");
            User u1 = new User(un1);

            UserName un2 = new UserName("Jorge", "Martins");
            User u2 = new User(un2);

            Request r = new Request(u1, u1, "Pedido de login", "Pedido de login para a aplicação HCis");
            Assert.AreEqual(r.Owner.Name.FirstName, "Vitor");
            Assert.AreNotEqual(r.Owner.Name.FirstName, "Mascarenhas");
            Assert.AreEqual(r.Owner.Name.LastName, "Mascarenhas");
            Assert.AreEqual(r.WhoRegistered.Name.FirstName, "Vitor");
            Assert.AreNotEqual(r.WhoRegistered.Name.FirstName, "Mascarenhas");
            Assert.AreEqual(r.WhoRegistered.Name.LastName, "Mascarenhas");

            Assert.AreEqual(r.Title, "Pedido de login");
            Assert.AreNotEqual(r.Description, "Pedido de login para HCis");

        }
    }
}
