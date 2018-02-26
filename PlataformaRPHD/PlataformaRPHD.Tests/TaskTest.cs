using Moq;
using NUnit.Framework;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Tests
{
    [TestFixture]
    public class TaskTest
    {
        [Test]
        public void ChangeTaskStatusTest()
        {
            UserName un1 = new UserName("Vitor", "Mascarenhas");
            User user1 = new User(un1, "info5292", "vitor.mascarenhas@ulsm.min-saude.pt", "1881");

            Mock<Task> mock = new Mock<Task>();
            
            Task task = new Task();

            var expectedOutcome = mock.Object;

            Assert.AreEqual(task.close, expectedOutcome.close);
            Assert.AreEqual(task.HistoryChangeStatus, expectedOutcome.HistoryChangeStatus);
            Assert.AreEqual(task.Owner, expectedOutcome.Owner);
            Assert.AreEqual(task.Resolution, expectedOutcome.Resolution);
            Assert.AreEqual(task.Status, expectedOutcome.Status);
            Assert.AreEqual(task.Transfers, expectedOutcome.Transfers);
        }

        [Test]
        public void ChangeTaskStatusTest1()
        {
            UserName un1 = new UserName("Vitor", "Mascarenhas");
            User user1 = new User(un1, "info5292", "vitor.mascarenhas@ulsm.min-saude.pt", "1881");

            Mock<Task> mock = new Mock<Task>();

            var expectedOutcome = mock.Object;
            expectedOutcome.ChangeStatus("Pendente", user1, "Aguardar material por parte do fornecedor");
            
            Task task = new Task();
            task.ChangeStatus("Pendente", user1, "Aguardar material por parte do fornecedor");

            Assert.AreEqual(task.close, expectedOutcome.close);
            Assert.AreEqual(task.HistoryChangeStatus, expectedOutcome.HistoryChangeStatus);
            Assert.AreEqual(task.Owner, expectedOutcome.Owner);
            Assert.AreEqual(task.Resolution, expectedOutcome.Resolution);
            Assert.AreEqual(task.Status, expectedOutcome.Status);
            Assert.AreEqual(task.Transfers, expectedOutcome.Transfers);
        }

        [Test]
        public void ChangeTaskStatusTest2()
        {
            UserName un1 = new UserName("Vitor", "Mascarenhas");
            User user1 = new User(un1, "info5292", "vitor.mascarenhas@ulsm.min-saude.pt", "1881");

            Mock<Task> mock = new Mock<Task>();

            var expectedOutcome = mock.Object;
            expectedOutcome.ChangeStatus("Pendente", user1, "Aguardar material por parte do fornecedor");

            Task task = new Task();
            task.ChangeStatus("Pendente", user1, "Aguardar material por parte do fornecedor");

            Assert.AreEqual(task.close, expectedOutcome.close);
            Assert.AreEqual(task.HistoryChangeStatus, expectedOutcome.HistoryChangeStatus);
            Assert.AreEqual(task.Owner, expectedOutcome.Owner);
            Assert.AreEqual(task.Resolution, expectedOutcome.Resolution);
            Assert.AreEqual(task.Status, expectedOutcome.Status);
            Assert.AreEqual(task.Transfers, expectedOutcome.Transfers);

            expectedOutcome.ChangeStatus("Aberto", user1, "Disponivel material para substituição");

            task.ChangeStatus("Aberto", user1, "Disponivel material para substituição");

            Assert.AreEqual(task.close, expectedOutcome.close);
            Assert.AreEqual(task.HistoryChangeStatus, expectedOutcome.HistoryChangeStatus);
            Assert.AreEqual(task.Owner, expectedOutcome.Owner);
            Assert.AreEqual(task.Resolution, expectedOutcome.Resolution);
            Assert.AreEqual(task.Status, expectedOutcome.Status);
            Assert.AreEqual(task.Transfers, expectedOutcome.Transfers);
        }

        [Test]
        public void ChangeTaskStatusTest3()
        {
            UserName un1 = new UserName("Vitor", "Mascarenhas");
            User user1 = new User(un1, "info5292", "vitor.mascarenhas@ulsm.min-saude.pt", "1881");

            Mock<Task> mock = new Mock<Task>();

            var expectedOutcome = mock.Object;
            expectedOutcome.ChangeStatus("Pendente", user1, "Aguardar material por parte do fornecedor");

            Task task = new Task();
            task.ChangeStatus("Pendente", user1, "Aguardar material por parte do fornecedor");

            Assert.AreEqual(task.close, expectedOutcome.close);
            Assert.AreEqual(task.HistoryChangeStatus, expectedOutcome.HistoryChangeStatus);
            Assert.AreEqual(task.Owner, expectedOutcome.Owner);
            Assert.AreEqual(task.Resolution, expectedOutcome.Resolution);
            Assert.AreEqual(task.Status, expectedOutcome.Status);
            Assert.AreEqual(task.Transfers, expectedOutcome.Transfers);

            expectedOutcome.ChangeStatus("Aberto", user1, "Disponivel material para substituição");

            task.ChangeStatus("Aberto", user1, "Disponivel material para substituição");

            Assert.AreEqual(task.close, expectedOutcome.close);
            Assert.AreEqual(task.HistoryChangeStatus, expectedOutcome.HistoryChangeStatus);
            Assert.AreEqual(task.Owner, expectedOutcome.Owner);
            Assert.AreEqual(task.Resolution, expectedOutcome.Resolution);
            Assert.AreEqual(task.Status, expectedOutcome.Status);
            Assert.AreEqual(task.Transfers, expectedOutcome.Transfers);

            expectedOutcome.ChangeStatus("Fechado", user1, "Disponivel material para substituição");

            task.ChangeStatus("Fechado", user1, "Disponivel material para substituição");

            Assert.AreEqual(task.close, expectedOutcome.close);
            Assert.AreEqual(task.HistoryChangeStatus, expectedOutcome.HistoryChangeStatus);
            Assert.AreEqual(task.Owner, expectedOutcome.Owner);
            Assert.AreEqual(task.Resolution, expectedOutcome.Resolution);
            Assert.AreEqual(task.Status, expectedOutcome.Status);
            Assert.AreEqual(task.Transfers, expectedOutcome.Transfers);
        }

        [Test]
        public void TransferTaskTest()
        {
            UserName un1 = new UserName("Vitor", "Mascarenhas");
            User user1 = new User(un1, "info5292", "vitor.mascarenhas@ulsm.min-saude.pt", "1881");

            UserName un2 = new UserName("João", "Santos");
            User user2 = new User(un2, "info5913", "joaopedro.santos@ulsm.min-saude.pt", "5425");

            UserName un3 = new UserName("Andreia", "Pinto");
            User user3 = new User(un3, "info4224", "andreia.pinto@ulsm.min-saude.pt", "5407");

        }
    }
}
