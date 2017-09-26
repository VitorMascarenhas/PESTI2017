using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class User
    {
        public int Id { get; set; }

        public UserName Name { get; set; }

        public string mechanographicNumber { get; set; }

        public string mail { get; set; }

        public string phoneNumber { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
        
        public string UserStatus { get; set; }

        private User() //EF
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
