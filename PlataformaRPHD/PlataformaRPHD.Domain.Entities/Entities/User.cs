using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class User : IEntity
    {
        public virtual int Id { get; set; }

        public virtual UserName Name { get; set; }

        public virtual string mechanographicNumber { get; set; }

        public virtual string mail { get; set; }

        public virtual string phoneNumber { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
        
        public virtual UserStatus userStatus { get; set; }

        private User()
        {
            this.Tasks = new HashSet<Task>();
            this.Requests = new HashSet<Request>();
        }

        public User(UserName userName)
        {
            this.Name = userName;
        }
    }
}
