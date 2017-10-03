﻿using NUnit.Framework;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Tests
{
    [TestFixture]
    public class RequestTest
    {
        [Test]
        public void ConstructorTest()
        {
            UserName un1 = new UserName("Vitor", "Mascarenhas");
            User u1 = new User(un1, "info5292", "vitor.mascarenhas@ulsm.min-saude.pt", "1881");

            UserName un2 = new UserName("Jorge", "Martins");
            User u2 = new User(un2, "med1109", "jorge.martins@ulsm.min-saude.pt", "5300");

            Request r = new Request(u1, u1, "Pedido de login", "Pedido de login para a aplicação HCis");
            Assert.AreEqual(r.Owner.Name.FirstName, "Vitor");
            Assert.AreNotEqual(r.Owner.Name.FirstName, "Mascarenhas");
            Assert.AreEqual(r.Owner.Name.LastName, "Mascarenhas");
            Assert.AreEqual(r.WhoRegistered.Name.FirstName, "Vitor");
            Assert.AreNotEqual(r.WhoRegistered.Name.LastName, "Mascarenhas");
            
            Assert.AreEqual(r.Title, "Pedido de login");
            Assert.AreNotEqual(r.Description, "Pedido de login para HCis");

        }
    }
}
