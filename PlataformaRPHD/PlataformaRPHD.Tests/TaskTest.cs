using NUnit.Framework;
using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Tests
{
    [TestFixture]
    public class TaskTest
    {
        private UserName un1;

        [Test]
        public void ChangeTaskStatusTest()
        {
            UserName un = new UserName("Vitor", "Mascarenhas");
            User u1 = new User(un);

            UserName un2 = new UserName("Pedro", "Sousa");
            User u2 = new User(un2);

            Service s1 = new Service();
            Category c3 = new Category("Aplicações informáticas", "Aplicações informáticas");
            Category c4 = new Category("Sonho", "Aplicação sonho");
            Topic t2 = new Topic(c3, c4);

            Request r1 = new Request(u1, u2, "Erro aplicação sonho.", "A aplicação sonho deixou de funcionar.");

            Interaction i1 = new Interaction(s1, t2, r1);
            
            Task task1 = new Task(u1, i1);
            int c = task1.HistoryChangeStatus.Count;
            Assert.AreEqual(c, 1);

            task1.ChangeStatus("Fechado");
            c = task1.HistoryChangeStatus.Count;
            Assert.AreEqual(c, 2);

            task1.ChangeStatus("Fechado");
            c = task1.HistoryChangeStatus.Count;
            Assert.AreEqual(c, 2);

            task1.ChangeStatus("Aberto");
            c = task1.HistoryChangeStatus.Count;
            Assert.AreEqual(c, 2);

            task1.ChangeStatus("Aberto");
            c = task1.HistoryChangeStatus.Count;
            Assert.AreEqual(c, 2);
            
            task1.ChangeStatus("Fechado");
            c = task1.HistoryChangeStatus.Count;
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

            Service s1 = new Service();
            Category c1 = new Category("Aplicações informáticas", "Aplicações informáticas");
            Category c2 = new Category("Sonho", "Sonho");
            Topic topic = new Topic(c1, c2);

            Request r1 = new Request(u1, u2, "Avaria de rato", "O rato deixou de funcionar.");

            Interaction i1 = new Interaction(s1, topic, r1);
            
            Task task = new Task(u1, i1);

            Assert.AreEqual(task.Owner.Id, 1);
            Assert.AreEqual(task.Owner.Name.FirstName, "Vitor");
            Assert.AreEqual(task.Owner.Name.LastName, "Mascarenhas");
            task.Transfer(u2, u3, "Impossibilidade.");

            Assert.AreEqual(task.Transfers.Count, 1);
            Assert.AreEqual(task.Owner.Name.FirstName, "Carlos");
            Assert.AreEqual(task.Owner.Name.LastName, "Alberto");

            task.Transfer(u2, u3, "Impossibilidade.");
            Assert.AreEqual(task.Owner.Id, 2);
            Assert.AreEqual(task.Owner.Name.FirstName, "Carlos");
            Assert.AreEqual(task.Owner.Name.LastName, "Alberto");



        }
    }
}
