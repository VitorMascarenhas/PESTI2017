using NUnit.Framework;
using PlataformaRPHD.DB.Domain;

namespace PlataformaRPHD.Tests
{
    [TestFixture]
    public class TaskTest
    {
        [Test]
        public void ChangeTaskStatusTest()
        {
            UserName un = new UserName("Vitor", "Mascarenhas");
            User u1 = new User(un);

            Interaction i1 = new Interaction(1, 2, 4);
            
            Task task1 = new Task(u1, i1);
            int c = task1.historyChangeTaskStatus.History.Count;
            Assert.AreEqual(c, 1);

            task1.ChangeStatus("Fechado");
            c = task1.historyChangeTaskStatus.History.Count;
            Assert.AreEqual(c, 2);

            task1.ChangeStatus("Fechado");
            c = task1.historyChangeTaskStatus.History.Count;
            Assert.AreEqual(c, 2);

            task1.ChangeStatus("Aberto");
            c = task1.historyChangeTaskStatus.History.Count;
            Assert.AreEqual(c, 2);

            task1.ChangeStatus("Aberto");
            c = task1.historyChangeTaskStatus.History.Count;
            Assert.AreEqual(c, 2);
            
            task1.ChangeStatus("Fechado");
            c = task1.historyChangeTaskStatus.History.Count;
            Assert.AreEqual(c, 2);
        }

        [Test]
        public void TransferTaskTest()
        {
            UserName un1 = new UserName("Vitor", "Mascarenhas");
            User u1 = new User(un1);
            u1.Id = 1;

            UserName un2 = new UserName("Carlos", "Alberto");
            User u2 = new User(un2);
            u2.Id = 2;

            UserName un3 = new UserName("João", "Alves");
            User u3 = new User(un3);
            u3.Id = 3;

            Interaction i1 = new Interaction(1, 2, 3);
            
            Task task = new Task(u1, i1);

            Assert.AreEqual(task.Owner.Id, 1);
            Assert.AreEqual(task.Owner.Name.FirstName, "Vitor");
            Assert.AreEqual(task.Owner.Name.LastName, "Mascarenhas");
            task.Transfer(u2, u3, "Impossibilidade.");

            Assert.AreEqual(task.HistoryOfTransfers.Transfers.Count, 1);
            Assert.AreEqual(task.Owner.Name.FirstName, "Carlos");
            Assert.AreEqual(task.Owner.Name.LastName, "Alberto");

            task.Transfer(u2, u3, "Impossibilidade.");
            Assert.AreEqual(task.Owner.Id, 2);
            Assert.AreEqual(task.Owner.Name.FirstName, "Carlos");
            Assert.AreEqual(task.Owner.Name.LastName, "Alberto");



        }
    }
}
