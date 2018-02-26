using Moq;
using NUnit.Framework;
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

            Category category1 = new Category(null, "Equipamento", "Equipamento");
            Category category2 = new Category(category1, "Rato", "Rato");
            Category category3 = new Category(category1, "Teclado", "Teclado");
            Category category4 = new Category(category1, "Monitor", "Monitor");
            
            Mock<RequestBuilder> mock = new Mock<RequestBuilder>();

            mock.Setup(m => m.WithCategory(category1));
            mock.Setup(m => m.WithComputer("pc613"));
            mock.Setup(m => m.WithContact("1325"));
            mock.Setup(m => m.WithDescription("Problema com Sclinico"));
            Impact impact = new Impact("Utilizador", 1);
            mock.Setup(m => m.WithImpact(impact));
            Origin origin = new Origin("Aplicação");
            mock.Setup(m => m.WithOrigin(origin));
            mock.Setup(m => m.WithOwner(u2));
            mock.Setup(m => m.WithTitle("Sclinico"));
            mock.Setup(m => m.WithWhoRegistered(u2));

            Request expected = new Request(u2, u2, "Sclinico", "Problema com Sclinico", category1, "pc613", "1325", origin, impact);

            var expectedOutcome = mock.Object.Build();

            Assert.AreEqual(expected.Category, expectedOutcome.Category);
            Assert.AreEqual(expected.SourceComputer, expectedOutcome.SourceComputer);
            Assert.AreEqual(expected.Contact, expectedOutcome.Contact);
            Assert.AreEqual(expected.Description, expectedOutcome.Description);
            Assert.AreEqual(expected.Impact, expectedOutcome.Impact);
            Assert.AreEqual(expected.Origin, expectedOutcome.Origin);
            Assert.AreEqual(expected.Owner, expectedOutcome.Owner);
            Assert.AreEqual(expected.Title, expectedOutcome.Title);
            Assert.AreEqual(expected.WhoRegistered, expectedOutcome.WhoRegistered);
        }
    }
}
